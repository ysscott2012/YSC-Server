using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using YSC_Server.DaoModels;
using YSC_Server.DbContext;
using YSC_Server.Interfaces;

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
            _leetcodeManagerService.Create(body);
            return Json("Create leetcode");
        }
        
        [HttpGet("leetcode/{id}")]
        public IActionResult Read(int id)
        {
            return Json("Read leetcode");
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