using System;

public class Animal
{
    public virtual void Raza()
    {
        Console.WriteLine("El animal tiene una raza");
    }
}

public class Perro : Animal
{
    public override void Raza()
    {
        Console.WriteLine("El perro es: Doberman");
    }
}

public class Gato : Animal
{
    public override void Raza()
    {
        Console.WriteLine("El gato es: Persa");
    }
}

class Program
{
    static void Main()
    {
        Animal perro = new Perro();
        Animal gato = new Gato();

        perro.Raza();
        gato.Raza();
    }
}
