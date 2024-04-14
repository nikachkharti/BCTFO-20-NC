using System.ComponentModel.DataAnnotations;

namespace HotelProject.Models.DataTransferObjects
{
    public class GuestWithReservationForUpdatingDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int GuestId { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(11)]
        public string PersonalNumber { get; set; }

        [Required]
        [MaxLength(25)]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        public int ReservationId { get; set; }

        [Required]
        public DateTime CheckInDate { get; set; }

        [Required]
        public DateTime CheckOutDate { get; set; }
    }
}
