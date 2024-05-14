using Todo.Entities;
using Todo.Models.Identity;

namespace Todo.Models
{
    public class TodoForGettingDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descrtiption { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; }
        public Status Status { get; set; }
        public Priority Priority { get; set; }
        public string UserId { get; set; }
        public UserDto User { get; set; }
    }
}
