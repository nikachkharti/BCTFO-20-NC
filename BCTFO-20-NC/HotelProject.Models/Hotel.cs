using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelProject.Models
{
    public class Hotel
    {
        //[Key]
        //[Required]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //[Required]
        //[MaxLength(50)]
        //[Column(TypeName = "NVARCHAR")]
        public string Name { get; set; }

        //[Required]
        public double Rating { get; set; }

        //[Required]
        //[MaxLength(50)]
        public string Country { get; set; }

        //[Required]
        //[MaxLength(50)]
        public string City { get; set; }

        //[Required]
        //[MaxLength(50)]
        public string PhyisicalAddress { get; set; }

        ///1X1
        public Manager Manager { get; set; }

        ///1xM
        public ICollection<Room> Rooms { get; set; }
    }
}
