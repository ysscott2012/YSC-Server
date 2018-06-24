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
            this.StatusCode = 200;
            this.StatusMessage = string.Empty;
            this.StatusTime = DateTime.Now;
        }
    }
}