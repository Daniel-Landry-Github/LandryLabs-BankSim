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
        Menu();
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
        bool menuOptionSelected = false;
        while (menuOptionSelected == false)
        {
            Console.WriteLine("\tLandry Labs Bank \n\tMENU OPTIONS:\n");
            Console.WriteLine("1. Dashboard \n2. Create New Account \n3. Deposit Funds \n4. Withdraw Funds");
            int selection = Convert.ToInt32(Console.ReadLine());
            if (selection == 1)
            {
                Console.WriteLine("\nDashboard is coming soon...\nReturning to Menu!\n");
                Thread.Sleep(1);
                Menu();
            }
            else if (selection == 2)
            {
                i = 0;
                
                Console.WriteLine("\nCreating new account...");
                Console.WriteLine("Enter name for new acccount: ");
                string newAccountName = Console.ReadLine();
                Console.WriteLine("Enter desired balance of new acccount: ");
                int newAccountBalance = Convert.ToInt32(Console.ReadLine());
                Account.CreateAccount(newAccountName, newAccountBalance);
                accountList
                Console.WriteLine("Account created! Returning to Menu!\n");
                Menu();
            }
        }
    }
    static void ListAccounts(Account[] accountList)
    {
        int i = 0;
        foreach (Account acct in accountList)
        {
            Console.WriteLine($"{acct}");
        }
        
    }
}

public class Account
{
    public string name;
    public int balance = 0;

    public void AccountInfo()
    {
        Console.WriteLine($"Account Name: {name}\nBalance: {balance}");
    }
    public static Account CreateAccount(string name, int balance)
    {
        //string accountName = Console.ReadLine();
        Account newAccount = new Account();
        newAccount.name = name;
        newAccount.balance = balance;
        return newAccount;
    }
    /* public int FundAccount(int balance)
    {

    } */
    public static void FetchInfo()
    {

    }
}