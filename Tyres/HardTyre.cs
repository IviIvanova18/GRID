using System;
using System.Collections.Generic;
using System.Text;

namespace GRID.Tyres
{
    class HardTyre : Tyre
    {
        private const string HardTyreName = "Hard";

        public HardTyre(double hardness) 
            : base(HardTyreName, hardness)
        {
        }
    }
}
