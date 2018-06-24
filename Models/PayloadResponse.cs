namespace YSC_Server.Models
{
    public class PayloadResponse<T>: ResponseBase
    {
        public T Payload { get; set; }
    }
}