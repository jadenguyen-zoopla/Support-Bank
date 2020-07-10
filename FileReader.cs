using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.IO.IsolatedStorage;
using System.Linq;

namespace Support_Bank
{   
    class FileReader {
        public static List<Transaction> ReadTransactionsFromFile() 
        {
            var transactions = new List<Transaction>();
            // do some stuff to add to the transactions
            // Get all of the lines from the CSV, but skip line 1
            var csvLines = File.ReadAllLines("Transactions2014.csv").Skip(1);
            // loop through each of those lines
            foreach(var line in csvLines) 
            {
                // line here is one single line from our file.
                // that line represents a single transaction.
                var parts = line.Split(",");
                var date = parts[0];
                var from = parts[1];
                var to = parts[2];
                var narrative = parts[3];
                var amount = parts[4];
                Console.WriteLine(parts);
            }
            // return the now full list of transactions
            return transactions;
        }
    }

}