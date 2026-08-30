using System;

public interface IMensaje
{
    void Enviar();
}

public class Correo : IMensaje
{
    public void Enviar()
    {
        Console.WriteLine("Enviando correo...");
    }
}

public class WhatsApp : IMensaje
{
    public void Enviar()
    {
        Console.WriteLine("Enviando mensaje por WhatsApp...");
    }
}

public class Usuario
{
    private IMensaje mensaje;

    public Usuario(IMensaje mensaje)
    {
        this.mensaje = mensaje;
    }

    public void Notificar()
    {
        mensaje.Enviar();
    }
}

class Program
{
    static void Main()
    {
        IMensaje correo = new Correo();

        Usuario usuario1 = new Usuario(correo);
        usuario1.Notificar();

        IMensaje whatsapp = new WhatsApp();

        Usuario usuario2 = new Usuario(whatsapp);
        usuario2.Notificar();
    }
}
