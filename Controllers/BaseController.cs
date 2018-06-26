using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace YSC_Server.API.Controllers
{
    public abstract class BaseController : Controller
    {
        private ILogger<BaseController> Logger { get; }
        protected BaseController(ILogger<BaseController> logger)
        {
            Logger = logger;
        }
    }
}