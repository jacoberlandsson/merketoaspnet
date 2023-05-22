using merketoaspnet.Contexts;
using merketoaspnet.Models.Entities;

namespace merketoaspnet.Helpers.Repositories
{
    public class UserAddressRepo : GeneralRepo<UserAddressEntity>
    {
        public UserAddressRepo(DataContext context) : base(context)
        {
        }
    }
}
