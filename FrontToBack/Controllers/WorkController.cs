using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Work()
        {
            return View();
        }
    }
}
