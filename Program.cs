using System;

namespace Support_Bank
{

    class Program
    {
        static void Main(string[] args)
        {
            var transactions = FileReader.ReadTransactionsFromFile();
            Console.WriteLine(transactions);
        }
    }
}
