using Microsoft.AspNetCore.Mvc;

namespace EndPoint.Site.Areas.User.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
