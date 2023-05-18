using merketoaspnet.Migrations;
using merketoaspnet.Models.Dtos;

namespace merketoaspnet.Models.ViewModels
{
    public class CollectionViewModel
    {
        public string? Title { get; set; }

        public IEnumerable<Product> NewProducts { get; set; } = new List<Product>();
        public IEnumerable<Product> PopularProducts { get; set; } = new List<Product>();
        public IEnumerable<Product> FeaturedProducts { get; set; } = new List<Product>();
    }
}
