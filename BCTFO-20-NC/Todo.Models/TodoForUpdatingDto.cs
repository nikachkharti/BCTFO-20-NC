using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Todo.Entities;

namespace Todo.Models
{
    public class TodoForUpdatingDto
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        public string Descrtiption { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; } = DateTime.Now;

        [Required]
        [DataType(DataType.Date)]
        //TODO შევქმნათ ატრობუტი რომელიც დარწმუნდება რომ EndDate უფრო მეტია ვიდრე StartDate
        public DateTime EndDate { get; set; }

        [Required]
        public Status Status { get; set; } = Status.Todo;

        [Required]
        public Priority Priority { get; set; } = Priority.Medium;
    }
}
