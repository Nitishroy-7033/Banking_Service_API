namespace bankservice.Common.Base
{
    public class Response
    {
        public bool Succeeded { set; get; } = true;
        public object? Data { get; set; }
        public string? Message { get; set; }
        public string? ResponseCode { get; set; }
    }
}
