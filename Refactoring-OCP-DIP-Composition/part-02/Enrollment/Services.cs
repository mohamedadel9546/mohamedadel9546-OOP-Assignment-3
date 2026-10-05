namespace RefactoringLab.Part02.Enrollment;

public class EnorellmentStudent
{
    public EnorellmentStudent(string studentId, string courseId, decimal amount)
    {
        this.studentId = studentId;
        this.courseId = courseId;
        this.amount = amount;
        paymentGateway = new();
        seatInventory = new();
        invoiceGenerator = new();
        emailService = new();
    }

    public string studentId { get; set; }
    public string courseId { get; set; }
    public decimal amount { get; set; }
    private readonly PaymentGateway paymentGateway ;
    private readonly SeatInventory seatInventory ;
    private readonly InvoiceGenerator invoiceGenerator ;
    private readonly EmailService emailService ;
    public void EnrollStudent()
    {
        paymentGateway.Charge(studentId,amount);
        seatInventory.Reserve(courseId, studentId);
        var invoiceId= invoiceGenerator.Create(studentId, amount);
        emailService.Send(studentId, "Enrollment confirmed", $"Invoice {invoiceId} for {courseId}");
    }

}
public class PaymentGateway
{
    public void Charge(string studentId, decimal amount) =>
        Console.WriteLine($"charge {studentId}: {amount}");
}

public class SeatInventory
{
    public void Reserve(string courseId, string studentId) =>
        Console.WriteLine($"reserve seat {courseId} for {studentId}");
}

public class InvoiceGenerator
{
    public string Create(string studentId, decimal amount)
    {
        var invoiceId = $"INV-{studentId}-{amount}";
        Console.WriteLine($"invoice {invoiceId}");
        return invoiceId;
    }
}

public class EmailService
{
    public void Send(string studentId, string subject, string body) =>
        Console.WriteLine($"email {studentId}: {subject} / {body}");
}
