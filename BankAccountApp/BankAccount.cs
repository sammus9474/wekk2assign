using System;
//Courtnee Sullivan
//PRG322 .NET Programming III - Jerrie Pineda
//My Bank Account Class 
class BankAccount
{
    private string name;
    private int accountId;
    private double balance;
    public BankAccount()
    {

    }
    //contructor this is overloaded
    public BankAccount(string str, int id, double bal)
    {
        name = str;
        accountId = id;
        
        try
        {
            if (bal < 0) //raises NegativeException
            {
                throw (new NegativeException("Constructor:Balance is negetive!!"));
            }
            else
                balance = bal;

        }
        catch (NegativeException e)
        {
            Console.WriteLine("NegativeException: {0}", e.Message);
        }
    }
    //functions for name, id and balance
    public void setName(string str)
    {
        name = str;
    }
    public void setAccountId(int id)
    {
        try
        {
            if (id < 0)
            {
                throw (new NegativeException("setAccoountId:id to set is negetive!!"));
            }
            else
                accountId = id;
        }
        catch (NegativeException e)
        {
            Console.WriteLine("NegativeException: ", e.Message);
        }
    }
    public void setBalance(double bal)
    {
        try
        {
            if (bal < 0)
            {
                throw (new NegativeException("setBalance:Balance to set is negetive!!"));
            }
            else
                balance = bal;
        }
        catch (NegativeException e)
        {
            Console.WriteLine("NegativeException: ", e.Message);
        }

    }
    //More functions
    public string getName()
    {
        return name;
    }
    public int getAccountId()
    {
        return accountId;
    }
    public double getBalance()
    {
        return balance;
    }
    public void withdraw(double amt)
    {
        if (balance > amt && (balance - amt > 100)) //minimum balance is 100
        {
            balance -= amt;
        }
        else
        {
            Console.WriteLine("Insufficient balance\n");
        }
    }
    public void deposit(double amt)
    {
        try
        {
            if (amt < 0)
            {
                throw (new NegativeException("Deposit:amount to deposit is negetive!!"));
            }
            else
                balance += amt;
        }
        catch (NegativeException e)
        {
            Console.WriteLine("NegativeException: {0}", e.Message);
        }

    }
}