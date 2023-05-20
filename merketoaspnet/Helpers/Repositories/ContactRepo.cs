using merketoaspnet.Contexts;
using merketoaspnet.Models.Entities;

namespace merketoaspnet.Helpers.Repositories
{
    public class ContactRepo : GeneralRepo<ContactFormEntity>
    {
        public ContactRepo(DataContext context) : base(context)
        {
        }
    }
}
