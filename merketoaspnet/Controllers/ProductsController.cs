using merketoaspnet.Helpers.Services;
using merketoaspnet.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace merketoaspnet.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductService _productService;

        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }

        public async Task <IActionResult> Index()
        {
            var viewModel = new ProductsViewModel
            {
                AllProducts = new ViewAllProductsViewModel
                {
                    Title = "All Products",
                    AllProducts = await _productService.GetAllProductsAsync()
                }

            };
            return View(viewModel);
        }
    }
}
