using Microsoft.AspNetCore.Mvc;

namespace merketoaspnet.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
