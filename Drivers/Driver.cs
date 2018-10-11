using System;
using System.Collections.Generic;
using System.Text;


namespace GRID.Drivers
{
    class Driver
    {
        public string Name { get; private set; }

        public double TotalTime { get; private set; }

        public Car Car { get; private set; }

        public double FuelConsumptionPerKm { get; private set; }

        private double speed;

        protected Driver(string name, double totalTime, Car car,double fuelConsumptionPerKm)
        {
            this.Name = name;
            this.TotalTime = totalTime;
            this.Car = car;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public double Speed
        {
            get
            {
                return this.speed;
            }
            set
            {
                //Speed = “(car’s Hp + tyre’s degradation) / car’s fuelAmount”
                value = (Car.Hp + Car.Tyre.Degradation) / Car.FuelAmount;
                this.speed = value;
            }
        }

       


    }
}
