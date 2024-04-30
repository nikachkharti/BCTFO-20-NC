using Todo.Entities;

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
    }
}
