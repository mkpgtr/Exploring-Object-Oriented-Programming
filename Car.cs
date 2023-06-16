using System;

namespace OOPExercise
{
    class Car
    {
        public string Make { get; }
        public string Model { get; }
        public int Year { get; }
        public string Color { get; }

        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        public void Start()
        {
            Console.WriteLine($"The {Color} {Make} {Model} is starting.");
        }

        public void Drive(int miles)
        {
            Console.WriteLine($"Driving {miles} miles in the {Make} {Model}.");
        }
    }

   
}
