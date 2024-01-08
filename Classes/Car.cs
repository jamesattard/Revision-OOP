using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Car
    {
        // Attributes (private)
        string model;
        string color;
        int topSpeed;

        // Constructors
        public Car()
        {
            model = string.Empty;
            color = string.Empty;
            topSpeed = 0;
        }

        public Car(string pModel, string pColor, int pTopSpeed)
        {
            model = pModel;
            color = pColor;
            topSpeed = pTopSpeed;
        }

        // Methods
        public void GetData()
        {
            Console.WriteLine($"This is a {color} {model} with a top speed of {topSpeed} km/h\n");
        }
    }
}
