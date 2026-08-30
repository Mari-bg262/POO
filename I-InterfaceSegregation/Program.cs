using System;

public interface IAnimal
{
    void Comer();
    void Caminar();
}

public interface IVolar
{
    void Volar();
}

public class Perro : IAnimal
{
    public void Comer()
    {
        Console.WriteLine("El perro está comiendo");
    }

    public void Caminar()
    {
        Console.WriteLine("El perro está caminando");
    }
}

public class Pajaro : IAnimal, IVolar
{
    public void Comer()
    {
        Console.WriteLine("El pájaro está comiendo");
    }

    public void Caminar()
    {
        Console.WriteLine("El pájaro está caminando");
    }

    public void Volar()
    {
        Console.WriteLine("El pájaro está volando");
    }
}

class Program
{
    static void Main()
    {
        Perro perro = new Perro();
        Pajaro pajaro = new Pajaro();

        perro.Comer();
        perro.Caminar();

        pajaro.Comer();
        pajaro.Caminar();
        pajaro.Volar();
    }
}
