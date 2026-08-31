using System;

public interface IMessageSender
{
    void Send(string message);
}


public class EmailSender : IMessageSender
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending email: {message}");
    }
}

public class NotificationService
{
    private readonly IMessageSender _messageSender;

    public NotificationService(IMessageSender messageSender)
    {
        _messageSender = messageSender;
    }

    public void Notify(string message)
    {
        _messageSender.Send(message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        IMessageSender emailSender = new EmailSender();
        NotificationService notificationService = new NotificationService(emailSender);
        notificationService.Notify("Hello, this is a notification!");
    }
}
