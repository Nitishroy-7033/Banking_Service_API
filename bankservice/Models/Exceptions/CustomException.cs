namespace bankservice.Models.Exceptions
{
    public class CustomException : Exception
    {
        public string ErrorCode { get; set; } = "500";
        public CustomException(string message) : base(message)
        {
        }

        public CustomException(string message, string errorCode) : base(message)
        {
            ErrorCode = errorCode;
        }
    }
}
