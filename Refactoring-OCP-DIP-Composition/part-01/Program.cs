using RefactoringLab;

 var Aramex = new Aramex();
 var FedEx = new FedEx();
 var Talapat = new Talapat();
 var shipping1 = new ShippingCostCalculator(Aramex);
 var shipping2 = new ShippingCostCalculator(FedEx);
 var shipping3 = new ShippingCostCalculator(Talapat);
 Console.WriteLine($"Aramex 2kg → {shipping1.CalculateCarrier(2)}");
 Console.WriteLine($"FedEx 2kg  → {shipping2.CalculateCarrier(2)}");
 Console.WriteLine($"Talapat 2kg  → {shipping3.CalculateCarrier(2)}");
 Console.WriteLine();
 
 var processor = new OrderProcess(new SqlOrderRepository(), new SmtpEmailSender());
 processor.Proccess(1001, "customer@example.com");
 Console.WriteLine();
 
 new ScheduledNotification(new UrganetSend(new EmailNotification())) { SendAt = DateTime.Today.AddHours(18) }
     .Send("customer@example.com", "Your order ships tomorrow");
 new UrganetSend(new SmsNotification())
    .Send("+201000000000", "OTP 4821");
