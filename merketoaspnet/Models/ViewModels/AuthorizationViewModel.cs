using Microsoft.AspNetCore.Identity;

namespace merketoaspnet.Models.ViewModels
{
    public class AuthorizationViewModel
    {
        public IList<IdentityUser> Users { get; set; } = new List<IdentityUser>();
        public IList<IdentityUser> Admins { get; set; } = new List<IdentityUser>();
    }
}
