using merketoaspnet.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace merketoaspnet.Controllers;

[Authorize(Roles = "admin")]
public class AdminController : Controller
{
    private readonly UserManager<IdentityUser> _userManager;
    

    public AdminController(UserManager<IdentityUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<IActionResult> Index()
    {
        var viewModel = new AuthorizationViewModel
        {
            Users = await _userManager.GetUsersInRoleAsync("user"),
            Admins = await _userManager.GetUsersInRoleAsync("admin")
        };
        
        return View(viewModel);
    }
}
