using System.ComponentModel.DataAnnotations;

namespace merketoaspnet.Models.ViewModels
{
    public class UserRegistrationViewModel
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "This field is required")]
        public string FirstName { get; set; } = null!;



        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "This field is required")]
        public string LastName { get; set; } = null!;



        [Display(Name = "Email")]
        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Email address is not formatted correctly")]
        public string Email { get; set; } = null!;



        [Display(Name = "Password")]
        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).{8,}$", ErrorMessage = "Password must be strong, please choose a better password")]
        public string Password { get; set; } = null!;



        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Passwords does not match")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ComparePassword { get; set; } = null!;


       

    }
}
