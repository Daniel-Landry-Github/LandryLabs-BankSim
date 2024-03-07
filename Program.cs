// BANK SIM
// Started 03/03/2024
// SCOPE:
// Accounts:
//      List existing accounts;
//      Create new accounts;
// Currency:
//      List existing currency;
//      Add/Subtract currency;
//      Move accross bank accounts;
// History:
//      Record and view account changes;
//      Record and view transactions;

using System;
using System.Threading;


public class Bank
{
    static void Main()
    {
        Account[] accountList = new Account[5];
        int accountListLength = accountList.Length;
        Menu(accountList);
        //Console.WriteLine($"Number of Account Slots: {accountListLength}.");
        
        //ListAccounts(accountList);

        /* if (accountList[0] == null)
        {
            Console.WriteLine("No account found. Creating new account...");
            Console.WriteLine("Enter name for new acccount: ");
            string newAccountName = Console.ReadLine();
            Console.WriteLine("Enter desired balance of new acccount: ");
            int newAccountBalance = Convert.ToInt32(Console.ReadLine());
            accountList[0] = Account.CreateAccount(newAccountName, newAccountBalance);
        }


        accountList[0].AccountInfo(); */


    }

    static void Menu(Account[] accountList)
    {
        Console.Clear();
        bool menuOptionSelected = false;
        while (menuOptionSelected == false)
        {
            Console.WriteLine("\tLANDRY LABS BANK \n\tMENU OPTIONS:\n");
            Console.WriteLine("\t(1. Account Dashboard)\n\t(2. Create New Account)\n\t(3. Exit.)");
            int selection = Convert.ToInt32(Console.ReadLine());
            if (selection == 1)
            {
                Console.Clear();
                // Account Dashboard to display overview list
                // And access account interaction options.
                ListAccounts(accountList);

                Console.WriteLine("\n");
                Thread.Sleep(3000);
                Menu(accountList);
                //Console.WriteLine("\nDashboard is coming soon...\nReturning to Menu!\n");
            }
            else if (selection == 2)
            {
                Console.Clear();
                int i = 0;
                foreach (Account acct in accountList)
                {
                    if (acct == null)
                    {
                        Console.WriteLine("\n\tCreating new account...");
                        Console.WriteLine("\tEnter name for new acccount: ");
                        string newAccountName = Console.ReadLine();
                        Console.WriteLine("\tEnter desired balance of new acccount: ");
                        int newAccountBalance = Convert.ToInt32(Console.ReadLine());
                        accountList[i] = Account.CreateAccount(newAccountName, newAccountBalance);
                        break;
                    }
                    else
                    {
                        i++;
                    }
                }
                
                //accountList
                Console.WriteLine("\tAccount created! Returning to Menu!\n");
                Menu(accountList);
            }
            else if (selection == 3)
            {
                Environment.Exit(0);
            }
        }
    }
    static void ListAccounts(Account[] accountList)
    {
        Console.WriteLine("\tLANDRY LABS BANK \n\tACCOUNT SLOTS:\n");
        //int i = 0;
        foreach (Account acct in accountList)
        {
            if (acct == null)
            {
                Console.WriteLine("SLOT EMPTY");
            }
            else
            {
                acct.AccountInfo();
            }

        }
        
    }

    /* public int FundAccount(Account name, int depositAmount)
    {
        
    } */
}

public class Account
{
    public string name;
    public int balance = 0;

    public void AccountInfo()
    {
        Console.WriteLine($"Account Name: {name}\tBalance: ${balance}");
    }
    public static Account CreateAccount(string name, int balance)
    {
        //string accountName = Console.ReadLine();
        Account newAccount = new Account();
        newAccount.name = name;
        newAccount.balance = balance;
        return newAccount;
    }
}