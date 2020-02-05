using System;
using System.Collections.Generic;

namespace SupportBank2
{
    class Program
    {
        static void Main(string[] args)
        {
            Reader reader = new Reader();
            reader.CreateTransactionList();
            // myAccount.SayHello();
            
            // Eventually will only say:
            
            // Printer.ListAll(Manager.AccountList);
            // Printer.ListTransactions(Console.Readline etc)
            // Could even ask the user which option they would like.
        }
    }
}