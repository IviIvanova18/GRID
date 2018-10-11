using System;
using System.Collections.Generic;
using System.Text;

namespace GRID.Tyres
{
    public  abstract class Tyre
    {

        public string Name { get;private set; }

        public double Hardness { get; private set; }

        private double degradation;

        private const int TyreDegradatin = 100;

        protected Tyre(string name, double hardness)//, double degradation)
        {
            this.Name = name;
            this.Hardness = hardness;
            //this.Degradation = degradation;
        }

        public double Degradation
        {
            get
            {
                return this.degradation;
            }
            set
            {

                value = TyreDegradatin - this.Hardness;
                this.degradation = value;

                if (value < 0)
                {
                    throw new InvalidOperationException("Tyre exploded!");
                }

                this.degradation = value;
            }
        }

        



    }
}
