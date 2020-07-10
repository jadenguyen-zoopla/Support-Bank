using System.Transactions;
using System.IO.IsolatedStorage;
using System;
using System.Collections.Generic;
using System.IO;

namespace Support_Bank
{
    public class Transaction
    {
        public string From;
        public string To;

        public Transaction(string from, string to)
        {
            From = from;
            To = to;
        }
    }


}
