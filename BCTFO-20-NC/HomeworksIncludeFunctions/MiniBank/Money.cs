using Homeworks.MiniBank.MiniBankExceptions;

namespace Homeworks.MiniBank
{
    public class Money
    {
        private double amount;
        public double Amount
        {
            get => amount;
            set
            {
                if (value > 0)
                {
                    amount = value;
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


        public Money(string currency, double amount)
        {
            Currency = currency;
            Amount = amount;
        }

        public Money(double amount)
        {
            Amount = amount;
        }

        public Money()
        {
        }

        public static Money operator -(Money m1, Money m2)
        {
            if (m1.Currency == m2.Currency)
            {
                return new Money(m1.Amount - m2.Amount);
            }
            else
            {
                throw new InvalidCurrencyException();
            }
        }

        public static Money operator +(Money m1, Money m2)
        {
            if (m1.Currency == m2.Currency)
            {
                return new Money(m1.Amount + m2.Amount);
            }
            else
            {
                throw new InvalidCurrencyException();
            }
        }

        public static bool operator >(Money m1, Money m2)
        {
            if (m1.Currency == m2.Currency)
            {
                return m1.Amount > m2.Amount;
            }
            else
            {
                throw new InvalidCurrencyException();
            }
        }

        public static bool operator <(Money m1, Money m2)
        {
            if (m1.Currency == m2.Currency)
            {
                return m1.Amount < m2.Amount;
            }
            else
            {
                throw new InvalidCurrencyException();
            }
        }

        public static bool operator >=(Money m1, Money m2)
        {
            if (m1.Currency == m2.Currency)
            {
                return m1.Amount >= m2.Amount;
            }
            else
            {
                throw new InvalidCurrencyException();
            }
        }

        public static bool operator <=(Money m1, Money m2)
        {
            if (m1.Currency == m2.Currency)
            {
                return m1.Amount <= m2.Amount;
            }
            else
            {
                throw new InvalidCurrencyException();
            }
        }

        public static bool operator !=(Money m1, Money m2)
        {
            if (m1.Currency == m2.Currency)
            {
                return m1.Amount != m2.Amount;
            }
            else
            {
                throw new InvalidCurrencyException();
            }
        }

        public static bool operator ==(Money m1, Money m2)
        {
            if (m1.Currency == m2.Currency)
            {
                return m1.Amount == m2.Amount;
            }
            else
            {
                throw new InvalidCurrencyException();
            }
        }

        public override string ToString() => $"{Amount} {Currency}";

    }
}
