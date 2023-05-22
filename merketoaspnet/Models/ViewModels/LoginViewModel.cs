using System.ComponentModel.DataAnnotations;

namespace merketoaspnet.Models.ViewModels
{
    public class LoginViewModel
    {
        
        public string Email { get; set; } = null!;


        public string Password { get; set; } = null!;

        public bool RememberMe { get; set; } = false;
    }
}
