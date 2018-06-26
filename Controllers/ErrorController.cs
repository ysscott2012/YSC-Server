using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using YSC_Server.Models;

namespace YSC_Server.API.Controllers
{
    public class ErrorController: BaseController
    {
        public ErrorController(ILogger<BaseController> logger) : base(logger)
        {
        }

        [Route("error")]
        public IActionResult Error()
        {
            return Json(new ResponseBase()
            {
                StatusMessage = "Server Error",
                StatusCode = 501
            });
        }
    }
}