using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Support_Bank
{
    public class FileReader
    {
        public static List<Transaction> ReadTransactions()
        {
            // Read all of the lines of text from the file.
            // (gets an array of strings - one string for each line)
            var linesFromFile = File.ReadAllLines("Transactions2014.csv");
            
            // create an empty list of transactions.
            var transactions = new List<Transaction>();
            
            // then loop through every line of the file
            // (skipping the first one as its the headers)
            foreach (var line in linesFromFile.Skip(1))
            {
                // for each line,
                // split it into the 5 parts by using the commas.
                var parts = line.Split(",");
                
                // Construct a new transaction
                // and populate all of its values using the parts of the string.
                var newTransaction = new Transaction();
                newTransaction.date = parts[0];
                newTransaction.from = parts[1];
                newTransaction.to = parts[2];
                newTransaction.narrative = parts[3];
                newTransaction.amount = Convert.ToDecimal(parts[4]);
                
                // add our newly created transaction to the list of all transactions.
                transactions.Add(newTransaction);
            }

            // and finally return all of the transactions.
            return transactions;
        }
    }
}










// using System;
// using System.Collections.Generic;
// using System.IO;
// using System.Net;
// using System.IO.IsolatedStorage;
// using System.Linq;

// namespace Support_Bank
// {   
//     class FileReader 
//     {
//         public static List<Transaction> ReadTransactionsFromFile() 
//         {
//             var transactions = new List<Transaction>();
//             // do some stuff to add to the transactions
//             // Get all of the lines from the CSV, but skip line 1
//             var csvLines = File.ReadAllLines("Transactions2014.csv").Skip(1);
//             // loop through each of those lines
//             foreach(var line in csvLines) 
//             {
//                 // line here is one single line from our file.
//                 // that line represents a single transaction.
//                 // line.Split(",") means split up the data using the coma and give each part an index
//                 var parts = line.Split(",");
//                 var date = parts[0];
//                 var from = parts[1];
//                 var to = parts[2];
//                 var narrative = parts[3];
//                 var amount = parts[4];

//                 //creating a new transaction passing in the parts 1 and 2
//                 var transaction = new Transaction(parts[1], parts[2]);
//                 transaction.Date = parts[0];
//                 //transaction.From = parts[1];
//                 //transaction.To = parts[2];
//                 transaction.Narrative = parts[3];
//                 transaction.Amount = Convert.ToDecimal(parts[4]);

//                 transactions.Add(transaction);

//                 Console.WriteLine(parts);
//             }
//             // return the now full list of transactions
//             return transactions;
//         }
//     }

// }