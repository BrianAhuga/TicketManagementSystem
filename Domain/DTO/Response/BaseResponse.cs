
namespace Domain.DTO.Response
{
    public class BaseResponse
    {
        public bool isSuccess { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;
    }

    public class BaseResponse<T>
    {
        public bool isSuccess { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;
        public T Value { get; set; }
    }
}
