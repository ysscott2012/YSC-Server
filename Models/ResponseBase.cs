using System;

namespace YSC_Server.Models
{
    public class ResponseBase
    {
        public string StatusMessage { get; set; }
        public int StatusCode { get; set; }
        public DateTime StatusTime { get; set; }
      
        public ResponseBase()
        {
            StatusCode = 200;
            StatusMessage = string.Empty;
            StatusTime = DateTime.Now;
        }
    }
}