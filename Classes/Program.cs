namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var myCar = new Cars();
            myCar.Make = "Honda";
            myCar.Model = "Civic";
            myCar.Year = 2003;

            var Volkswagen = new Cars("Volkswagen", "Beetle", 2018);
            var VW = new Cars("Volkswagen", "Cabriolet", 1986);

            var carList = new List<Cars>() { myCar, Volkswagen, VW };

            foreach (var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }



        }


        
    }
}