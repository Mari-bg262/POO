using System;
using System.Security.Cryptography.X509Certificates;

public abstract class Bird
{
    public abstract void Fly();
}

public class Sparrow : Bird { 

    public override void Fly()
    {
        Console.WriteLine("Sparrow is flying.");
    }
}

class program
{
    static void Main(string[] args)
    {
        Bird sparrow = new Sparrow();
        sparrow.Fly();
    }
}
