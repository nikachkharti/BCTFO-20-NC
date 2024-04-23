using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace HotelProject.Models.DTOS
{
    public class UserRegistrationDto
    {
        [Required]
        [DisplayName("სახელი")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("გვარი")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [DisplayName("ელ-ფოსტა")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [DisplayName("პაროლი")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password don't match")]
        [DisplayName("გაიმეორეთ პაროლი")]
        public string ConfirmPassword { get; set; }
    }
}
