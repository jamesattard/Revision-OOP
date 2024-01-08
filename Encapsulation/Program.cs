namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Car("BMW", "Black", 200);
            bmw.GetData();

            // Use Property to update color
            bmw.Color = "White";
            bmw.GetData();

            // Use Method to update color
            bmw.PaintCar("Silver");
            bmw.GetData();
        }
    }
}
