using FuelTracker.Core.Entities;

namespace FuelTracker.Core.Commands
{
    public class FillUpPresenter
    {
        private readonly FillUp _fillUp;

        public FillUpPresenter(FillUp fillUp)
        {
            _fillUp = fillUp;
        }

        public decimal Gallons => _fillUp.Gallons;

        public int OdometerReading => _fillUp.OdometerReading;

        public decimal TotalCost => _fillUp.TotalCost;

        public decimal PricePerGallon => _fillUp.PricePerGallon;
    }
}