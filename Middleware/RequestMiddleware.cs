using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using YSC_Server.Models;

namespace YSC_Server.Middleware
{
   public class RequestMiddleware
   {
       private readonly RequestDelegate _next;

       public RequestMiddleware(RequestDelegate next)
       {
           _next = next ?? throw new ArgumentNullException(nameof(next));
       }

       public async Task Invoke(HttpContext context)
       {
           try
           {
               await _next(context);
           }
           catch (Exception ex)
           {
               await HandleExceptionAsync(context, ex);
           }                                 
       }
       
       private Task HandleExceptionAsync(HttpContext context, Exception exception)
       {
           var result = JsonConvert.SerializeObject(new ResponseBase
           {
               StatusMessage= exception.Message,
               StatusCode = 501
           });
           context.Response.ContentType = "application/json";
           context.Response.StatusCode = (int) HttpStatusCode.InternalServerError;
           return context.Response.WriteAsync(result);
       }
   }
}