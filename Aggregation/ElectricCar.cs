using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    internal class ElectricCar : Car
    {
        // Attributes (Private)
        int chargingTime;

        // Properties (Public)
        public int ChargingTime
        {
            get
            {
                return chargingTime;
            }
            set
            {
                chargingTime = value;
            }
        }

        // Constructors
        public ElectricCar(string pModel, string pColor, int pTopSpeed, int pMaxPassengers, int pChargingTime) 
            : base(pModel, pColor, pTopSpeed, pMaxPassengers)
        {
            chargingTime = pChargingTime;
        }

        // Methods
        public override string GetData()
        {
            return base.GetData() +
                $"This vehicle takes {chargingTime} minutes to fully charge.\n";
        }
    }
}
