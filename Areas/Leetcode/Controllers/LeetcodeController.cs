using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using YSC_Server.DaoModels;
using YSC_Server.DbContext;
using YSC_Server.Interfaces;
using YSC_Server.Models;

namespace YSC_Server.API.Controllers
{
    [Area("v1")]
    [Route("[area]/algorithms")]
    public class LeetcodeController: BaseController
    {
        private readonly ILeetcodeManagerService _leetcodeManagerService;
        
        public LeetcodeController(ILeetcodeManagerService leetcodeManagerService, ILogger<BaseController> logger) : base(logger)
        {
            _leetcodeManagerService = leetcodeManagerService;
        }
        
        [HttpPost("leetcode")]
        public IActionResult Create([FromBody] Leetcode body)
        {
            Leetcode leetcode = _leetcodeManagerService.Create(body);
            return Json(new PayloadResponse<Leetcode>(leetcode));
        }
        
        [HttpGet("leetcode/{id}")]
        public IActionResult Read(int id)
        {
            Leetcode leetcode = _leetcodeManagerService.Read(1);
            return Json(new PayloadResponse<Leetcode>(leetcode));
        }
        
        [HttpPut("leetcode/{id}")]
        public IActionResult UpdateAndReplace(int id, [FromBody] Leetcode body)
        {
            return Json("UpdateAndReplace leetcode");
        }
        
        [HttpPatch("leetcode/{id}")]
        public IActionResult UpdateAndModify(int id)
        {
            return Json("UpdateAndModify leetcode");
        }
        
        [HttpDelete("leetcode/{id}")]
        public IActionResult Delete(int id)
        {
            return Json("Delete leetcode");
        }
    }
}