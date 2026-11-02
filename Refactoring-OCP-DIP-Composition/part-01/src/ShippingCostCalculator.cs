namespace RefactoringLab;

    public interface ICarrier
    {

        decimal Calculate(decimal weightKg);
    }

    public class Aramex : ICarrier
    {
        public decimal Calculate(decimal weightKg)
        {
            return weightKg * 12m;
        }
    }
    public class FedEx : ICarrier
    {
        public decimal Calculate(decimal weightKg)
        {
            return weightKg * 15m;
        }
    }
    public class DHL : ICarrier
    {
        public decimal Calculate(decimal weightKg)
        {
            return weightKg * 18m;
        }
    }
public class Talapat : ICarrier
{
    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 2m;
    }
}

public class ShippingCostCalculator
    {
        private readonly ICarrier carrier;

        public ShippingCostCalculator(ICarrier carrier)
        {
            this.carrier = carrier;
        }

        public decimal CalculateCarrier(decimal weightKg)
        {
            return carrier.Calculate(weightKg);
        }

    }

