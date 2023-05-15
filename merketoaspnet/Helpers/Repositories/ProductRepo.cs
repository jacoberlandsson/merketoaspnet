using merketoaspnet.Contexts;
using merketoaspnet.Models.Entities;

namespace merketoaspnet.Helpers.Repositories
{
    public class ProductRepo : GeneralRepo<ProductEntity>
    {
        public ProductRepo(DataContext context) : base(context)
        {
        }
    }
}
