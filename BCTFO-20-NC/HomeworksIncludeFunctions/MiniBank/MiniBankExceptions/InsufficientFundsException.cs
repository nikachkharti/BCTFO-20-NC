using System.Runtime.Serialization;

namespace Homeworks.MiniBank.MiniBankExceptions
{
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException() : base("Insufficient funds")
        {
        }
    }

}
