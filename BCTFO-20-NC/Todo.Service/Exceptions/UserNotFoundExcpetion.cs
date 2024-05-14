namespace Todo.Service.Exceptions
{
    public class UserNotFoundExcpetion : Exception
    {
        public UserNotFoundExcpetion() : base("User not found")
        {
        }
    }
}
