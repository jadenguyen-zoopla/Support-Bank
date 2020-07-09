 using System.IO.IsolatedStorage;
using System;
using System.Collections.Generic;
using System.IO;

namespace Support_Bank
{   
    public class FileReader 
    {
        public List<Transaction> ReadTransactions()
        {
            var csvLines :|Enumberable<string> = File.ReadLines(path: "Transactions2014.csv");
        }
    }

}