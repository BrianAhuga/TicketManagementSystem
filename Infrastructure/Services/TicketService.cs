using Domain.DTO.Request;
using Domain.DTO.Response;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Repository;
using Infrastructure.Common;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class TicketService : ITicketService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IWebHostEnvironment webHostEnvironment;

        public TicketService(IUnitOfWork unitOfWork,
            IHttpContextAccessor httpContextAccessor,
            IWebHostEnvironment webHostEnvironment)
        {
            this.unitOfWork = unitOfWork;
            this.httpContextAccessor = httpContextAccessor;
            this.webHostEnvironment = webHostEnvironment;
        }


        public async Task<BaseResponse<int>> CreateTicket(CreateTicketRequest request)
        {
            var createTicketResult = new BaseResponse<int>() { isSuccess = false };
            var uploadPath = Path.Combine(webHostEnvironment.WebRootPath,
                "uploads", "attachments");

            try
            {
                var currentUser = httpContextAccessor.HttpContext.User.Claims
                    .FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier).Value;
                if (currentUser == null)
                {
                    createTicketResult.ErrorMessage = "User is not valid, please re-login";
                    return createTicketResult;
                }

                Ticket ticket = new Ticket();
                ticket.Summary = request.Summary;
                ticket.Description = request.Description;
                ticket.ProductId = request.ProductId.Value;
                ticket.CategoryId = request.CategoryId.Value;
                ticket.PriorityId = request.PriorityId.Value;
                ticket.AssignedToId = request.AssignedToId;
                ticket.RaisedBy = currentUser;
                ticket.RaisedDate = DateTime.Now;
                ticket.Status = Constants.STATUS_NEW;

                var priority = unitOfWork.Repository<Priority>().GetByIdAsync(request
                    .PriorityId.Value);
                if (priority != null)
                {
                    ticket.ExpectedDate = DateTime.Now.AddDays(priority.ExpectedDays);
                }

                unitOfWork.TicketRepository.Add(ticket);

                if (request.files != null && request.files.Count > 0)
                {
                    foreach (var file in request.files)
                    {
                        var fileExt = Path.GetExtension(file.Name);
                        var actualName = Path.GetFileNameWithoutExtension(file.Name);

                        var fileName = $"{actualName}-{Guid.NewGuid().ToString()}{fileExt}";
                        var filePath = Path.Combine(uploadPath, fileName);

                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await file.OpenReadStream().CopyToAsync(fileStream);
                        }

                        Attachment attachment = new Attachment
                        {
                            Ticket = ticket,
                            FileName = Path.GetFileName(file.Name),
                            ServerFileName = fileName,
                            FileSize = file.Size,
                            CreatedDate = DateTime.Now
                        };
                        unitOfWork.Repository<Attachment>().Add(attachment);
                    }
                }

                var result = await unitOfWork.SaveChanges() > 0;
                if (result)
                {
                    createTicketResult.isSuccess = true;
                    createTicketResult.Value = ticket.TicketId;
                    return createTicketResult;
                }
                else
                {
                    createTicketResult.ErrorMessage = "Failed when creating ticket!";
                    return createTicketResult;
                }
            }
            catch (Exception ex)
            {
                createTicketResult.ErrorMessage = "Failed: " + ex.Message;
                return createTicketResult;
            }
        }

        public GetTicketResponse FindTicket(int ticketId)
        {
            var result = unitOfWork.TicketRepository.FindTicket(ticketId);
            if (result == null) return null;

            var attachmentpath = Path.Combine("uploads", "attachments");

            return new GetTicketResponse
            {
                TicketId = result.TicketId,
                Summary = result.Summary,
                Description = result.Description,
                ProductId = result.ProductId,
                PriorityId = result.PriorityId,
                CategoryId = result.CategoryId,
                Status = result.Status,
                AssignedToId = result.AssignedToId,
                RaisedBy = result.User?.Id,
                RaisedByName = result.User?.Email,
                RaisedByAvatar = result.User?.Avatar,
                CreatedDate = result.RaisedDate,
                ExpectedDate = result.ExpectedDate,
                ClosedBy = result.ClosedBy,
                ClosedByDate = result.ClosedByDate,

                Attachments = result.Attachments.Select(x => new AttachmentResponse
                {
                    FileName = x.FileName,
                    ServerFileName = Path.Combine(attachmentpath, x.ServerFileName)
                }).ToList()
            };
        }

        public List<GetTicketResponse> GetTickets(GetTicketRequest request)
        {
            var result = unitOfWork.TicketRepository.GetTickets(request);

            return result.Select(x => new GetTicketResponse
            {
                TicketId = x.TicketId,
                Summary = x.Summary,
                Product = x.Product?.ProductName,
                Category = x.Category?.CategoryName,
                Priority = x.Priority?.PriorityName,
                Status = x.Status,
                RaisedBy = x.User?.Email,
                CreatedDate = x.RaisedDate,
                ExpectedDate = x.ExpectedDate
            }).ToList();
        }

        public async Task<BaseResponse> UpdateTicket(UpdateTicketRequest request)
        {
            var result = new BaseResponse();
            result.isSuccess = false;

            var currentTicket = unitOfWork.TicketRepository.GetByIdAsync(request.TicketId);
            if (currentTicket == null)
            {
                result.ErrorMessage = "Ticket not found!";
                return result;
            }

            currentTicket.ProductId = request.ProductId.Value;
            currentTicket.CategoryId = request.CategoryId.Value;
            currentTicket.PriorityId = request.PriorityId.Value;
            currentTicket.AssignedToId = request.AssignedToId;

            currentTicket.Status = request.Status;
            currentTicket.LastUpdatedDate = DateTime.Now;

            if (request.Status == Constants.STATUS_CLOSED)
            {
                currentTicket.ClosedByDate = DateTime.Now;

                var currentUser = httpContextAccessor.HttpContext.User.Claims.
                    FirstOrDefault(x => x.Type == ClaimTypes.Name).Value;
                if (currentUser == null)
                {
                    result.ErrorMessage = "User is not valid, please re-login";
                    return result;
                }

                currentTicket.ClosedBy = currentUser;
            }

            unitOfWork.TicketRepository.Update(currentTicket);

            var dbResult = await unitOfWork.SaveChanges() > 0;
            if (dbResult)
            {
                result.isSuccess = true;
            }
            else
            {
                result.ErrorMessage = "Failed when saving to database! Try again later.";
            }

            return result;
        }

        public List<ChartResponse> Last12MonthsTickets()
        {
            return unitOfWork.TicketRepository.Last12MonthsTickets();
        }

        public List<ChartResponse> ChartByCategory(string category)
        {
            return unitOfWork.TicketRepository.ChartByCategory(category);
        }

        public List<ChartResponse> GetSummary()
        {
            return unitOfWork.TicketRepository.GetSummary();
        }
    }
}


