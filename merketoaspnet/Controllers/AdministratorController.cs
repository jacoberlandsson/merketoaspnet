using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace merketoaspnet.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdministratorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
