using Microsoft.AspNetCore.Mvc;

namespace merketoaspnet.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
