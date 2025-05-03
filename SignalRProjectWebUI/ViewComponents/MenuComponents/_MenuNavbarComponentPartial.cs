using Microsoft.AspNetCore.Mvc;

namespace SignalRProjectWebUI.ViewComponents.MenuComponents
{
    public class _MenuNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
