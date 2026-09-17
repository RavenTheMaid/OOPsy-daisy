namespace OOP_car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new();
            car.Brand = "thisisacoolbrand";
            car.Model = "glibglob123123";
            car.DateOfManufacture = new DateTime(1900, 9, 9);
            car.NewPrice = 500000;
            car.DrivenKM = 0;

            double carPrice = car.CalculateCarPrice();
            Console.WriteLine(carPrice);
        }
    }
}
