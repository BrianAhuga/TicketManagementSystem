using Domain.DTO.Request;
using Domain.DTO.Response;
using System;

namespace Domain.Interfaces
{
    public interface IDiscussionService
    {
        List<DiscussionResponse> GetDiscussions(int ticketId);
        Task<BaseResponse> Create(CreateDiscussionRequest request);
    }
}
