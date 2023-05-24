using Microsoft.AspNetCore.Mvc;

namespace merketoaspnet.Controllers
{
    public class AccessDeniedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
