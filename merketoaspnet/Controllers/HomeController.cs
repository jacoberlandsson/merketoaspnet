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
            New = new ProductByTagsViewModel
            {
                Title = "New",
                NewProducts = await _productService.GetAllByTagNameAsync("New")
            },

            Popular = new ProductByTagsViewModel
            {
                Title = "Popular",
                PopularProducts = await _productService.GetAllByTagNameAsync("Popular")




            },

            Featured = new ProductByTagsViewModel
            {
                Title = "Featured",
                NewProducts = await _productService.GetAllByTagNameAsync("Featured")
            }

        };
        
        
        return View(viewModel);
    }

    public async Task<IActionResult> Products()
    {
        var viewModel = new HomeViewModel
        {
            New = new ProductByTagsViewModel
            {
                Title = "New",
                NewProducts = await _productService.GetAllByTagNameAsync("New")
            },

            Popular = new ProductByTagsViewModel
            {
                Title = "Popular",
                PopularProducts = await _productService.GetAllByTagNameAsync("Popular")




            },

            Featured = new ProductByTagsViewModel
            {
                Title = "Featured",
                NewProducts = await _productService.GetAllByTagNameAsync("Featured")
            }

        };


        return View(viewModel);
    }
}
