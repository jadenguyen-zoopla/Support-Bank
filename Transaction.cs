using System;

namespace Support_Bank
{
    class Transaction
    {
        public string Name;
        public string To;
    }

    public class FileReader 
    {
        public List<Transaction> ReadTransactions()
        {
            var csv :|Enumberable<string> = File.ReadLines(path: "Transactions2014.csv");
        }
    }
}
