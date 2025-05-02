using Microsoft.AspNetCore.Mvc;

namespace SignalRProjectWebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
