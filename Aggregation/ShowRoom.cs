using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    internal class ShowRoom
    {
        // Attributes (private)
        string address;
        List<Vehicle> vehicles = new List<Vehicle>();

        // Properties (public)
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public List<Vehicle> Vehicles
        {
            get
            {
                return vehicles;
            }
            set
            {
                vehicles = value;
            }
        }

        // Constructors
        public ShowRoom(string pAddress, List<Vehicle> pVehicles)
        {
            address = pAddress;
            vehicles = pVehicles;
        }

        // Methods
        public void ListVehicles()
        {
            Console.WriteLine("Vehicles inside this showroom: \n");
            foreach (Vehicle v in vehicles)
            {
                Console.WriteLine(v.GetData());
            }
        }
    }
}
