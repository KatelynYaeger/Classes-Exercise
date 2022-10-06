using System;
namespace Classes
{
    public class Cars
    {

        public Cars(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }


        public Cars()
        {
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        
    }
}