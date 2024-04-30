namespace Todo.Service.Exceptions
{
    public class TodoNotFoundException : Exception
    {
        public TodoNotFoundException() : base("Todo not found in the database")
        {
        }
    }
}
