using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class BankMain
    {
        static void InsufficientBalanceMsg()
        {
            Console.WriteLine("Error: Insufficient balance.");
        }

        static void LowBalanceMsg()
        {
            Console.WriteLine("Warning: Your balance is low.");
        }

        static void ZeroBalanceMsg()
        {
            Console.WriteLine("Warning: Your balance is zero.");
        }
        static void Main(string[] args)
        {
            Bank b = new Bank(2000);

            b.InsufficientBalance += new BalanceEventHandler(InsufficientBalanceMsg);
            b.LowBalance += new BalanceEventHandler(LowBalanceMsg);
            b.ZeroBalance += new BalanceEventHandler(ZeroBalanceMsg);

            b.Credit(2000);
            b.Debit(4000);
            b.Debit(3000);
            b.Debit(100);
        }
    }
}
