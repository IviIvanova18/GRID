using System;
using System.Collections.Generic;
using System.Text;

namespace GRID.Drivers
{
    class EnduranceDriver : Driver
    {
        private const double EnduranceDriverFuelConsumptionPerKm = 2.7;

        protected EnduranceDriver(string name, double totalTime, Car car)
            : base(name, totalTime, car, EnduranceDriverFuelConsumptionPerKm)
        {
        }
    }
}
