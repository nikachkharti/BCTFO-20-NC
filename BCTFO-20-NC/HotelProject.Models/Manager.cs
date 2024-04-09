using System.ComponentModel.DataAnnotations.Schema;

namespace HotelProject.Models
{
    public class Manager
    {
        //[Key]
        //[Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //[Required]
        //[MaxLength(50)]
        public string FirstName { get; set; }

        //[Required]
        //[MaxLength(50)]
        public string LastName { get; set; }


        ///1X1
        //[Required]
        //[ForeignKey(nameof(Hotel))]
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
    }
}
