using System.ComponentModel.DataAnnotations;

namespace merketoaspnet.Models.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        public string FirstName { get; set; } = null!;


        [Required]
        public string LastName { get; set; } = null!;


        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;

        [Required]
        public string Message { get; set; } = null!;
    }
}
