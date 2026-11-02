namespace RefactoringLab;

public interface IOrderSave
{
    void Save(int orderId, DateTime processedAt);
}
public interface IOrderSend
{
    void Send(string to, string body);
}
public class SqlOrderRepository : IOrderSave
{
    public void Save(int orderId, DateTime processedAt) =>
        Console.WriteLine($"[SQL] save order {orderId} @ {processedAt:O}");
}
public class SmtpEmailSender : IOrderSend
{
    public void Send(string to, string body) =>
        Console.WriteLine($"[SMTP] to={to} body={body}");
}

public class OrderProcess
{
    private readonly IOrderSave Save;
    private readonly IOrderSend Send;

    public OrderProcess(IOrderSave save, IOrderSend send)
    {
        Save = save;
        Send = send;
    }

    public void Proccess(int id, string CustopmerEmail)
    {
        DateTime dateTime = DateTime.Now;
        Save.Save(id, dateTime);
        Send.Send(CustopmerEmail, $"Order {id} confirmed at {dateTime}");
    }

}
