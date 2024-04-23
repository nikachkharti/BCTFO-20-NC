using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HotelProject.Models.DTOS
{
    public class UserLoginDto
    {
        [Required]
        [EmailAddress]
        [DisplayName("ელ-ფოსტა")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [DisplayName("პაროლი")]
        public string Password { get; set; }

        [DisplayName("დამახსოვრება")]
        public bool RememberMe { get; set; }
    }
}
