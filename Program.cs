using System;

namespace Support_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read all the transactions from the file.
            var transactions = FileReader.ReadTransactions();
            
            // and then use those transactions to create the accounts we will need.
            var accounts = Bank.GetAccounts(transactions);

            // loop through the list of accounts and for each account found print to the console the account name
            foreach (var account in accounts)
            {
                Console.WriteLine(account.name);
            }

            var UpdatedAccounts = Bank.UpdatedAccounts(transactions, accounts);

            Console.WriteLine(UpdatedAccounts);
        }
    }
}








// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace Support_Bank
// {

//     class Program
//     {
//         static void Main(string[] args)
//         {   
//             // creating a variable called transactions that runs the ReadTransactionsFromFile() function created on the FileReader file
//             // the FileReader file does all the hard work reading stuff
//             var transactions = FileReader.ReadTransactionsFromFile();
//             // print the results found that is now stored in the transaction variable
//             Console.WriteLine(transactions);

//             // using our GetAccounts method and passing in transactions to use the transactions data that we got from FileReader file
//             var accounts = GetAccounts(transactions);

//             var amounts = accounts.Select(account=>account.GetTotalAmount());
//             var thing = 5;

//         }

//         static List<Account> GetAccounts(List<Transaction> transactions) 
//         // created a method that will create a list called 'GetAccounts' that will go through the list of transactions
//         // and store all the names within the 'GetAccounts' list
//         {
//             // created a varible called 'names' that will run the getNames function by passing through transactions)
//             var names = getNames(transactions);
//             // created an empty list off accounts and sorted it in a new varible called 'allAccounts'
//             var allAccounts = new List<Account>();

//             // looping through all the names and for each name found we are going to call it currentName
//             foreach(var currentName in names)
//             {
//                 // created a new account for every currentName and stored it in a new varible called currentAccount (one singlar account)
//                 var currentAccount = new Account(currentName);
//                 // calling a method that will add that singular account to the full list of accounts
//                 allAccounts.Add(currentAccount);
//             }

//             // returning allAccounts so that the program can use it
//             return allAccounts;

//         }

//         static HashSet<string> getNames(List<Transaction> transactions)
//         // making a new HastSet which means that it is a list that cant be changed
//         // we passed through the paramter of trasaction which gives us the list of transactions
//         {
//             // created a HastSet list that is made up of strings and storing it in a varble called allNames
//             var allNames = new HashSet<string>();

//             // for each iteration of that loop we are goin to call that transaction currentTransaction
//             foreach(var currentTransaction in transactions)
//             {
//                 //so we had created an empty set of names and now we are looping through all the transactions
//                 // for each transaction we want to add to the list of names
//                 // we want to add the values from the transactions stored in 'To' and 'From'
//                 allNames.Add(currentTransaction.To);
//                 allNames.Add(currentTransaction.From);
//             }

//             // return the list stored in the variable allNames
//             return allNames;
//         }
//     }
// }
