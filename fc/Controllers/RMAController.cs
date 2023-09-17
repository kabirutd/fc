using Microsoft.AspNetCore.Mvc;

namespace fc.Controllers
{
    public class RMAController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RMA()
        {
            return View();
        }

        public IActionResult RMAV2()
        {
            return View();
        }
    }
}
