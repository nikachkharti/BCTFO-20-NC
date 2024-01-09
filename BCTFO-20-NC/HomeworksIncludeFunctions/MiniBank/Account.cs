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


        private string currency;
        public string Currency
        {
            get { return currency; }
            set
            {
                if (value.Length == 3)
                {
                    currency = value;
                }
            }
        }


        private double balance;
        public double Balance
        {
            get { return balance; }
            set
            {
                if (value > 0)
                {
                    balance = value;
                }
            }
        }

        public void Fill(double balance)
        {
            Balance += balance;
        }

        public void Withdraw(double balance)
        {
            if (Balance >= balance)
            {
                Balance -= balance;
            }
            else
            {
                throw new InsufficientFundsException();
            }
        }

        public void Transfer(Account accountToTransfer, double amountToTransfer)
        {
            if (Balance >= amountToTransfer)
            {
                Balance -= amountToTransfer;
                accountToTransfer.Balance += amountToTransfer;
            }
            else
            {
                throw new InsufficientFundsException();
            }
        }

    }
}
