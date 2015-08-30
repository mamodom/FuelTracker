namespace FuelTracker.Core.Commands
{
    public class AddFillUpCommand
    {
        public int OdometerReading { get; set; }

        public decimal TotalCost { get; set; }

        public decimal Gallons { get; set; }
    }
}