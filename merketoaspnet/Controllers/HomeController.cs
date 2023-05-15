using Microsoft.AspNetCore.Mvc;

namespace merketoaspnet.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
