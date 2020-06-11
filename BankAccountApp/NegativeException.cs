using System;
//Courtnee Sullivan
//PRG322 .NET Programming III - Jerrie Pineda
//My Negative Exception Class 
class NegativeException : Exception
{
    public NegativeException()
    {

    }

    public NegativeException(string message) : base(message)
    {
        Console.WriteLine("NegativeException:negetive value");
    }

}
