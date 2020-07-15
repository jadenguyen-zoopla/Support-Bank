using System.Transactions;
using System.Collections.Generic;
using NLog;

namespace Support_Bank
{
    public class Bank
    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();

        public static List<Account> GetAccounts(List<Transaction> transactions) 
        //Creating individual accounts for each person
        {
            Logger.Info("Getting unique names");
            // find all of the unique names of people in the team.
            var names = GetUniqueNames(transactions);

            // then create an empty list of accounts
            var accounts = new List<Account>();

            // loop through all of the names
            foreach (var name in names)
            {
                Logger.Debug($"creating account for {name}");
                // and for each name, create the new account
                var account = new Account(name);
                
                // and then add the new account to the list.
                accounts.Add(account);
            }

            // finally return all the accounts!
            return accounts;
        }

        private static HashSet<string> GetUniqueNames(List<Transaction> transactions)
        // Creating a method to get every persons name
        {
            // create a new empty set to hold all our names.
            var names = new HashSet<string>();

            // then loop through all of the transactions.
            foreach (var transaction in transactions)
            {
                // for each transaction, add the from and to names to the set.
                // the set will handle all the duplicates for us and ensure everything is unique.
                names.Add(transaction.from);
                names.Add(transaction.to);
            }

            // and then return all of the names.
            return names;
        }

        public static List<Account> UpdatedAccounts(List<Transaction> transactions, List<Account> accounts)
        // Created new method called UpdatedAccounts using the Account class, and passing through the list of transactions and list of accounts
        {
            // Loop through the transactions list and for every transaction that is found in the from column, add it to the outgoingTransaction list that matches
            foreach(var transaction in transactions)
            {
                var account = findAccount(transaction.from, accounts);
                account.outgoingTransactions.Add(transaction);
            }
    
             // Loop through the transactions list and for every transaction that is found in the to column, add it to the incomingTransaction list that matches  
            foreach(var transaction in transactions)
            {
                var account = findAccount(transaction.to, accounts);
                account.incomingTransactions.Add(transaction);
            }

            // return the accounts list 
            return accounts;
        }

        public static Account findAccount(string name, List<Account> accounts)
        // Created a new method called findAccounts that passes through the parameters name and accounts
        // The point of this method is to loop through and find the matches of name to the name of the account
        // The 'name' is just a string e.g. Sarah T. 'accounts' is a list of our accounts. 'account' holds and instance of the accounts.
        
        // we needed to get the list of accounts to make a new list called updated accounts. In order to do that, we needed to iterate through each transactions in the transaction section.
        // We're looking for the 'from' name of our transaction and add it onto the outgoing transactions account
        {
            foreach(var account in accounts)
            {
                //if the name matches the account name then return account
                if(name == account.name)
                {
                    return account;
                }
            }
            // if not then dont return anything
            return null;
        }
    }
}