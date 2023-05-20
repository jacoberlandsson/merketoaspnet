using merketoaspnet.Helpers.Services;
using Microsoft.AspNetCore.Mvc;

namespace merketoaspnet.Controllers
{
    public class ProductDetailsController : Controller
    {
        private readonly ProductService _productService;

        public ProductDetailsController(ProductService productService)
        {
            _productService = productService;
        }

        public async Task <IActionResult> Index(string articleNumber)
        {
            var product = await _productService.GetProductByArticleNumberAsync(articleNumber);
            return View(product);
        }
    }
}
