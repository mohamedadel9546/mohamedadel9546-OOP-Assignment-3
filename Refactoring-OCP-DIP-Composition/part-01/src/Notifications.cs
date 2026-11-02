namespace RefactoringLab;

public interface INotification
{
    void Send(string to, string message);
}

public class EmailNotification : INotification
{
    public void Send(string to, string message)
    => Console.WriteLine($"[email] {to}: {message}");
}
public class SmsNotification : INotification
{
    public void Send(string to, string message)
    => Console.WriteLine($"[Sms] {to}: {message}");
}
public class Telegram : INotification
{
    public void Send(string to, string message)
     => Console.WriteLine($"[Telegram] {to}: {message}");
}

public class UrganetSend : INotification
{
    private readonly INotification notification = null!;

    public UrganetSend(INotification notification)
    {
        this.notification = notification;
    }

    public void Send(string to, string message)
    {
        notification.Send(to, $"[URGENT] {message}");
    }
}

public class ScheduledNotification : INotification
{
    public DateTime SendAt { get; set; }
    private readonly UrganetSend notification1 = null!;

    public ScheduledNotification(UrganetSend notification1)
    {
        this.notification1 = notification1;
    }

    public void Send(string to, string message)
    {
        Console.WriteLine($"[scheduled {SendAt:g}] ");
        notification1.Send(to, $"{message}");
    }
}
