using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Vehicle
    {
        // Attributes (private)
        string model;
        string color;
        int topSpeed;

        // Properties (public)
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public int TopSpeed
        {
            get
            {
                return topSpeed;
            }
            set
            {
                topSpeed = value;
            }
        }

        // Constructors
        public Vehicle()
        {
            model = string.Empty;
            color = string.Empty;
            topSpeed = 0;
        }

        public Vehicle(string pModel, string pColor, int pTopSpeed)
        {
            model = pModel;
            color = pColor;
            topSpeed = pTopSpeed;
        }

        // Methods
        public virtual string GetData()
        {
            return $"A {color} {model} with a top speed of {topSpeed} km/h\n";
        }
    }
}
