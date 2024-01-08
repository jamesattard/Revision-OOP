using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Car
    {
        // Attributes (private)
        string model;
        string color;
        int topSpeed;

        // Properties (public)
        public string Model {
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
                Console.WriteLine($"Value was changed from {color} to {value}");
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

        public void PaintCar(string color)
        {
            Color = color;
        }
    }
}
