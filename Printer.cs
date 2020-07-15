using System;
using System.Collections.Generic;
using System.Linq;

namespace Support_Bank
{
    public enum DaysOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    
    public enum Mode
    {
        AllAccountSummary,
        SingleAccountDetails
    }
    
    public class Printer
    {
        public static void DisplayOutput(List<Account> accounts)
        {
            var mode = GetCurrentMode();
            if (mode == Mode.AllAccountSummary)
            {
                PrintAllAccountsSummary(accounts);
            }
            else
            {
                PrintSingleAccountSummary(accounts);
            }
        }

        private static void PrintSingleAccountSummary(List<Account> accounts)
        {
            var account = GetSpecificAccount(accounts);
            
            Console.WriteLine($"Account details for {account.name}\n");
            Console.WriteLine($"Total Owed to {account.name}: {account.GetTotalIncoming()}");
            Console.WriteLine($"Total Owed by {account.name}: {account.GetTotalOutgoing()}");
        }

        private static void PrintAllAccountsSummary(List<Account> accounts)
        {
            foreach (var account in accounts)
            {
                Console.WriteLine($"Name: {account.name} - Total Owed: {account.GetTotalToPay()}");
            }
        }

        private static Mode GetCurrentMode()
        {
            while (true)
            {
                Console.WriteLine("Please select the mode");
                Console.WriteLine("Enter '1' for All account summary");
                Console.WriteLine("Enter '2' for Single Account Details");

                var userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    return Mode.AllAccountSummary;
                }

                if (userInput == "2")
                {
                    return Mode.SingleAccountDetails;
                }

                Console.WriteLine("Sorry - please enter either 1 or 2");
            }
        }

        private static Account GetSpecificAccount(List<Account> accounts)
        {
            while (true)
            {
                Console.WriteLine("Please enter the name of the account:");
                var accountName = Console.ReadLine();
                try
                {
                    return accounts.First(account => account.name == accountName);
                }
                catch (InvalidOperationException exception)
                {
                    Console.WriteLine($"Sorry - there is no account for the name {accountName}. \nPlease try again.\n\n");
                }
            }
        }
    }
}