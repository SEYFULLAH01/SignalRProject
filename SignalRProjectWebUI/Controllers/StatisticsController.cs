using Microsoft.AspNetCore.Mvc;

namespace SignalRProjectWebUI.Controllers
{
    public class StatisticsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
