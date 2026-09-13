namespace Domain.DTO.Request
{
    public class GetTicketRequest
    {
        public string? Summary { get; set; }
        public int[]? ProductId { get; set; }
        public int[]? CategoryId { get; set; }
        public int[]? PriorityId { get; set; }
        public int[]? Status { get; set; }
        public int[]? RaisedBy { get; set; }
    }
}
