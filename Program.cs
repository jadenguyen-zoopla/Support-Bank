using System;

namespace Support_Bank
{

    class Program
    {
        static void Main(string[] args)
        {   
            // creating a variable called transactions that runs the ReadTransactionsFromFile() function created on the FileReader file
            var transactions = FileReader.ReadTransactionsFromFile();
            // print the results found that is now stored in the transaction variable
            Console.WriteLine(transactions);
        }
    }
}
