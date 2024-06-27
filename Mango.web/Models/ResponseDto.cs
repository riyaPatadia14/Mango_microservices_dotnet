namespace Mango.web.Models
{
    public class ResponseDto
    {
        public object Result { get; set; } = new object();
        public bool IsSuccess { get; set; } = true;
        public string Message { get; set; } = string.Empty;
    }
}
