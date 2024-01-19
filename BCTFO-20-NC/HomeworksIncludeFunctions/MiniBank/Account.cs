using Homeworks.MiniBank.MiniBankExceptions;

namespace Homeworks.MiniBank
{
    public class Account
    {
        private string accountNumber;
        public string AccountNumber
        {
            get { return accountNumber; }
            set
            {
                if (value.Length == 22)
                {
                    accountNumber = value;
                }
            }
        }
        public Money Money { get; set; }

        public void Fill(double balance)
        {
            Money.Amount += balance;
        }

        public void Withdraw(double balance)
        {
            if (Money.Amount >= balance)
            {
                Money.Amount -= balance;
            }
            else
            {
                throw new InsufficientFundsException();
            }
        }

        public void Transfer(Account accountToTransfer, double amountToTransfer)
        {
            if (Money.Amount >= amountToTransfer)
            {
                Money.Amount -= amountToTransfer;
                accountToTransfer.Money.Amount += amountToTransfer;
            }
            else
            {
                throw new InsufficientFundsException();
            }
        }

    }
}
