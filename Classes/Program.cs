namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {

            var myCar = new Car()
            {
                Make = "Toyota",
                Model = "Camry TRD",
                Year = 2022,
            };

            Console.WriteLine($"I own a {myCar.Year} {myCar.Make} {myCar.Model}.");







        }
    }
}
