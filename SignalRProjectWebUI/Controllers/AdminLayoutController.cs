using Microsoft.AspNetCore.Mvc;

namespace SignalRProjectWebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
