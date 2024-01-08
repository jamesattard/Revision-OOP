namespace Aggregation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car ferrari = new Car("Ferrari", "red", 200, 2);
            ElectricCar leaf = new ElectricCar("Leaf", "white", 100, 4, 3600);

            ShowRoom jamesShowRoom = new ShowRoom("James Mansions, Manikata", new List<Vehicle> { ferrari, leaf });
            jamesShowRoom.ListVehicles();
        }
    }
}
