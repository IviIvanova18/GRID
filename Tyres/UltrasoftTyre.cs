using System;
using System.Collections.Generic;
using System.Text;

namespace GRID.Tyres
{
    class UltrasoftTyre : Tyre
    {
        public double Grip { get;private set; }
        private const string UltrasoftTyreName = "Ultrasoft";
        private double degradation;
        private const double TyreDegradatin = 100;

        public UltrasoftTyre(double hardness,double grip)
            : base(UltrasoftTyreName, hardness)
        {
            this.Grip = grip;
        }

        public new double Degradation
        {
            get
            {
                return this.degradation;
            }
            set
            {

                value = TyreDegradatin - (this.Hardness + this.Grip);
                this.degradation = value;

                if (value < 30)
                {
                    throw new InvalidOperationException("Tyre exploded!");
                }

                this.degradation = value;
            }
        }
    }
}
