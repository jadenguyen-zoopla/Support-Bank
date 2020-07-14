using System.Collections.Generic;

namespace Support_Bank
{
    public class Account
    {
        public string name;
        public List<Transaction> incomingTransactions;
        public List<Transaction> outgoingTransactions;
        
        public Account(string name)
        {
            // the constructor asks us to supply a name when we create the account.
            // it then sets the name
            // and initialises the incoming and outgoing transactions as an empty list.
            this.name = name;
            incomingTransactions = new List<Transaction>();
            outgoingTransactions = new List<Transaction>();
        }
        
        public decimal GetTotalIncoming()
        {
            // loops through all of the incoming transactions,
            // and adds up the total value of the incoming transactions.
            var total = new decimal(0);

            foreach (var transaction in incomingTransactions)
            {
                total = total + transaction.amount;
            }

            return total;
        }

        public decimal GetTotalOutgoing()
        {
            // loops through all of the outgoing transactions,
            // and adds up the total value of the outgoing transactions.
            var total = new decimal(0);

            foreach (var transaction in outgoingTransactions)
            {
                total = total + transaction.amount;
            }

            return total;
        }

        public decimal GetTotalToPay()
        {
            // Get the total amount that the person needs to pay.
            // which is just all the money that they owe to others, minus all the money owed to them.
            return GetTotalOutgoing() - GetTotalIncoming();
        }
    }
}











// using System.Transactions;
// using System.IO.IsolatedStorage;
// using System;
// using System.Collections.Generic;
// using System.IO;

// namespace Support_Bank
// {
//     public class Account
//     {
//         public string Name;

//         public List<Transaction> Owed;

//         public List<Transaction> Owe;

//         public Account(string name)
//         // saying that every time we create an account, we have to give it a parameter name (which is a string)
//         {
//             // setting Name to be name
//             Name = name;
//             // we dont know how much they owe/owed so we create empty lists
//             Owed = new List<Transaction>();
//             Owe = new List<Transaction>();

//         }

//         public decimal GetTotalAmount()
//         // created a new method called GetTotalAmount that returns a decimal
//         //the point of this method is to return the sum of whatever the owe/are owed
//         {
//             // working out the total amount that they are owed
//             // have to convert number to decimal otherwise it thinks its an integar but we need it as a decimal
//             var totalOwed = new Decimal(0);
//             // loop through all the transactions in the 'Owed' list keep adding to the total
//             foreach(var currentOwedTransaction in Owed)
//             {
//                 // for each one, every time we hit an owed transaction we will add to the total amount that we are owed
//                 totalOwed = totalOwed + currentOwedTransaction.Amount;
//             }
//             foreach(var currentOweTransaction in Owe)
//             {
//                 // then what we do is loop through all the transactions which we owe somebody else
//                 // and for each one of those we subtract that transaction from our total
//                 totalOwed = totalOwed - currentOweTransaction.Amount;
//             }
//             // return the total owed
//             return totalOwed;

            
//         }


//     }




// }