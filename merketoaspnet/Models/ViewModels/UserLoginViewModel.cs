using System.ComponentModel.DataAnnotations;

namespace merketoaspnet.Models.ViewModels
{
    public class UserLoginViewModel
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;


        [Display(Name = "Password")]
        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
    }
}
