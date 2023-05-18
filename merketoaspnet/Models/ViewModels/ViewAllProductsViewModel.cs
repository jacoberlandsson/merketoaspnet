using merketoaspnet.Models.Dtos;

namespace merketoaspnet.Models.ViewModels
{
    public class ViewAllProductsViewModel
    {
        public string? Title { get; set; }

        public IEnumerable<Product> AllProducts { get; set; } = new List<Product>();
    }
}
