using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    internal class Car : Vehicle
    {
        // Attributes (Private)
        int maxPassengers;

        // Properties (Public)
        public int MaxPassengers
        {
            get
            {
                return maxPassengers;
            }
            set
            {
                maxPassengers = value;
            }
        }

        // Constructors
        public Car(string pModel, string pColor, int pTopSpeed, int pMaxPassengers) 
            : base(pModel, pColor, pTopSpeed)
        {
            maxPassengers = pMaxPassengers;
        }

        // Methods
        public override string GetData()
        {
            return base.GetData() +
                $"Can carry up to {maxPassengers} passengers...\n";
        }
    }
}
