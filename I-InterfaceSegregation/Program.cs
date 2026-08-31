using System;
using System.Collections.Generic;
using System.Text;
public interface IWork {
    void Work();
}

public interface IEat
{
    void Eat();
}

public class  Human : IWork, IEat { 

    public void Work() { Console.WriteLine("Working"); }
    public void Eat() { Console.WriteLine("Eating"); }
}

public class Robot : IWork
{ 
    public void Work() { Console.WriteLine("Working"); }
}

class Program
{
    static void Main(string[] args)
    {
        IWork humanWorker = new Human();
        humanWorker.Work();
        IWork robotWorker = new Robot();
        robotWorker.Work();
    }
}
