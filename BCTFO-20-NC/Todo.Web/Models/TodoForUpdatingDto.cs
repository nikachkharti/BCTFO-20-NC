using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Todo.Web.Models
{
    public class TodoForUpdatingDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; } = DateTime.Now;

        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Required]
        public Status Status { get; set; } = Status.Todo;

        [Required]
        public Priority Priority { get; set; } = Priority.Medium;

        [Required]
        public string UserId { get; set; }
    }
}
