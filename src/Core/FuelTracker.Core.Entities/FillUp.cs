namespace FuelTracker.Core.Entities
{
    public class FillUp
    {
        public decimal Gallons { get; set; }

        public int OdometerReading { get; set; }

        public decimal TotalCost { get; set; }

        public decimal PricePerGallon { get; set; }
    }
}