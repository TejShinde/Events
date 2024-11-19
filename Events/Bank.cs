using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void BalanceEventHandler();

    public class Bank
    {
        public event BalanceEventHandler InsufficientBalance;
        public event BalanceEventHandler LowBalance;
        public event BalanceEventHandler ZeroBalance;

        private decimal balance;
        public Bank(decimal initialBalance)
        {
            balance = initialBalance;
            CheckBalanceConditions();
        }

        public void Credit(decimal amount)
        {
            balance = balance + amount;
            Console.WriteLine($"Amount credited: {amount}, Current balance: {balance}");
            CheckBalanceConditions();
        }

        public void Debit(decimal amount)
        {
            if (amount > balance)
            {
                InsufficientBalance?.Invoke();
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Amount debited: {amount}. Current Balance: {balance}");
                CheckBalanceConditions();
            }
        }
        private void CheckBalanceConditions()
        {
            if (balance == 0)
            {
                ZeroBalance?.Invoke();
            }
            else if (balance < 3000)
            {
                LowBalance?.Invoke();
            }
        }
    }
}
