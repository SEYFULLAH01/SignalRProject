using Microsoft.AspNetCore.Mvc;

namespace SignalRProjectWebUI.Controllers
{
    public class ProgressBarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
