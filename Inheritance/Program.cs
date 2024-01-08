namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car ferrari = new Car("Ferrari", "red", 200, 2);
            Console.WriteLine(ferrari.GetData());

            ElectricCar leaf = new ElectricCar("Leaf", "white", 100, 4, 3600);
            Console.WriteLine(leaf.GetData());
        }
    }
}
