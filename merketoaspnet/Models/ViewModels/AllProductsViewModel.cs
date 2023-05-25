using merketoaspnet.Models.Dtos;

namespace merketoaspnet.Models.ViewModels
{
    public class AllProductsViewModel
    {
        public string? Title { get; set; }
        public IEnumerable<Product> AllProducts { get; set; } = new List<Product>();
    }
}
