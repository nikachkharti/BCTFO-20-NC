namespace Homeworks.MiniBank.MiniBankExceptions
{
    public class InvalidCurrencyException : Exception
    {
        public InvalidCurrencyException() : base("Used currency is invalid")
        {
        }
    }
}
