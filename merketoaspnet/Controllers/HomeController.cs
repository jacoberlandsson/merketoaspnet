using merketoaspnet.Helpers.Services;
using merketoaspnet.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace merketoaspnet.Controllers;

public class HomeController : Controller
{
    private readonly ProductService _productService;

    public HomeController(ProductService productService)
    {
        _productService = productService;
    }

    public async Task <IActionResult> Index()
    {
        var viewModel = new HomeViewModel
        {
            New = new CollectionViewModel
            {
                Title = "New",
                NewProducts = await _productService.GetAllByTagNameAsync("New")
            },

            Popular = new CollectionViewModel
            {
                Title = "Popular",
                PopularProducts = await _productService.GetAllByTagNameAsync("Popular")




            },

            Featured = new CollectionViewModel
            {
                Title = "Featured",
                NewProducts = await _productService.GetAllByTagNameAsync("Featured")
            }

        };
        
        
        return View(viewModel);
    }
}
