using System;
//Courtnee Sullivan
//PRG322 .NET Programming III - Jerrie Pineda
//My Main Class for testing 
class BankCheckTest
{
    static void Main()
    {
        //Testing output
        BankAccount account = new BankAccount("Courtnee", 456, -3);
        BankAccount account1 = new BankAccount();
        account1.setBalance(-2);
        account1.setAccountId(-4);
        account1.withdraw(100);

        //setting valid inputs
        account1.setName("Courtnee Sullivan");
        account1.setAccountId(789456);
        account1.setBalance(1000);
        
        //account outputs
        Console.WriteLine("Account Id: " + account1.getAccountId());
        Console.WriteLine("Account name: " + account1.getName());
        Console.WriteLine("Intial Balance: " + account1.getBalance());
      
        //deposits 
        account1.deposit(-2);
        account1.deposit(50.5);
        Console.WriteLine("New balance after deposit of 100: " + account1.getBalance());
        
        //withdrawal
        account1.withdraw(1000);
        account1.withdraw(2.50);
        Console.WriteLine("New balance after withdraw of 200.85: " + account1.getBalance());
    }
}