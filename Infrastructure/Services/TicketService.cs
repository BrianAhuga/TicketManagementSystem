using Domain.DTO.Request;
using Domain.DTO.Response;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Repository;
using Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class TicketService : ITicketService
    {
        private readonly IUnitOfWork unitOfWork;
        public TicketService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public GetTicketResponse FindTicket(int ticketId)
        {
            var result = unitOfWork.Repository<Ticket>().GetByIdAsync(ticketId);
            if (result == null) return null;

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
                CreatedDate = result.RaisedDate,
                ExpectedDate = result.ExpectedDate
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
                currentTicket.ClosedDate = DateTime.Now;
                currentTicket.ClosedBy = "...";
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
    }
}


