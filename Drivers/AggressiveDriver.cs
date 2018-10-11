using System;
using System.Collections.Generic;
using System.Text;
using GRID.Drivers;

namespace GRID.Drivers
{
    class AggressiveDriver : Driver
    {
        
        private const double AggressiveDriverFuelConsuption = 2.7;

        protected AggressiveDriver(string name, double totalTime, Car car) : base(name, totalTime, car, AggressiveDriverFuelConsuption)
        {
            base.Speed *= 1.3;
        }

        //public AggressiveDriver(string name, double totalTime, Car car)
        //    : base(name, totalTime, car, AggressiveDriverFuelConsuptionPerKm)
        //{
        //    base.Speed *= 1.3;
        //}

    }
}
