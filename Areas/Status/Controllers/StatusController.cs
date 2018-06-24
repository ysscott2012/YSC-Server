using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using YSC_Server.Controllers;
using YSC_Server.Models;

namespace YSC_Server.API.Controllers
{
    [Area("v1")]
    [Route("")]
    [Route("v1/status")]
    public class StatusController : BaseController
    {
        public StatusController(ILogger<BaseController> logger) : base(logger)
        {
        }

        [HttpGet]
        [HttpGet("index")]
        [HttpGet("serverStatus")]
        public IActionResult ServerStatus()
        {
            return Json(new ResponseBase());
        }
        
    }
}