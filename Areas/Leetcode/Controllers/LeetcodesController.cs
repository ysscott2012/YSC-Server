using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace YSC_Server.API.Controllers
{
    [Area("v1")]
    [Route("[area]/algorithms")]
    public class LeetcodesController: BaseController
    {
        public LeetcodesController(ILogger<BaseController> logger) : base(logger)
        {
        }
        
        [HttpGet("leetcodes")]
        public IActionResult Read()
        {
            return Json("Read leetcodes");
        }
    }
}