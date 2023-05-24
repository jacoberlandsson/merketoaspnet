using merketoaspnet.Helpers.Services;
using merketoaspnet.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace merketoaspnet.Controllers
{
   
    public class LogoutController : Controller
    {
        private readonly AuthenticationService _authenticationService;

        public LogoutController(AuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        public async Task<IActionResult> Index()
        {

                    await _authenticationService.LogoutAsync();
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    
           
        }
    }
}
