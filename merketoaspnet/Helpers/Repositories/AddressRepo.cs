using merketoaspnet.Contexts;
using merketoaspnet.Models.Entities;

namespace merketoaspnet.Helpers.Repositories
{
    public class AddressRepo : GeneralRepo<AddressEntity>
    {
        public AddressRepo(DataContext context) : base(context)
        {
        }
    }
}
