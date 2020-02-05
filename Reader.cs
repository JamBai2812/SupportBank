using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace SupportBank2
{
    public class Reader
    {
        public List<Transaction> CreateTransactionList()
        {
            var transactionList = new List<Transaction>();
            //Creates list of strings containing each line of information in the file.
            //removes the first line (headings)
            var lines = File.ReadAllLines("support-bank-resources/Transactions2014.csv");
            var lineList = lines.OfType<string>().ToList();
            lineList.RemoveAt(0);
            
            //creates a transaction object for each line and populates its properties.
            //adds each transaction to a list of transactions.
            foreach (var line in lineList)
            {
                string[] values = line.Split(',');
                var transaction = new Transaction();
                transaction.transactionDate = values[0];
                transaction.from = values[1];
                transaction.to = values[2];
                transaction.narrative = values[3];
                transaction.amount = float.Parse(values[4]);
                
                transactionList.Add(transaction);
            }

            return transactionList;

            //  Checking that transaction list is correctly populated
            /*foreach (var transaction in transactionList)
           {
               Console.WriteLine(transaction.amount);
           }*/



            //path = C:\Training2\SupportBank2\SupportBank2\support-bank-resources\Transactions2014.csv
            //Read file and create transaction objects
            //Add transactions to list

            //return transactionList;
        }

        public static List<Account> CreateAccountList()
        {
            var accountList = new List<Account>();
            
            //Read file and create account objects
            //Add accounts to list

            return accountList;
        }
    }
}