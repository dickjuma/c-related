using System;

namespace InterfaceExample
{
    public interface IVehicle
    {
        int Doors { get; set; }
        int Wheels { get; set; }
        int Topspeed { get; set; }
        int Cylinder { get; set; }
        int Currentspeed { get; }
        string DisplayTopSpeed();
        void Accelerate(int step);
    }

    public class Car : IVehicle
    {
        private int currentSpeed;

        public int Doors { get; set; }
        public int Wheels { get; set; }
        public int Topspeed { get; set; }
        public int Cylinder { get; set; }

        public int Currentspeed => currentSpeed;

        public string DisplayTopSpeed()
        {
            return $"The top speed of the car is {Topspeed} mph.";
        }

        public void Accelerate(int step)
        {
            currentSpeed += step;
            Console.WriteLine($"Accelerating. Current speed: {Currentspeed} mph");
        }
    }

    class Program
    {
        static void Main()
        {
            // Example usage
            IVehicle myCar = new Car
            {
                Doors = 4,
                Wheels = 4,
                Topspeed = 150,
                Cylinder = 6
            };

            Console.WriteLine(myCar.DisplayTopSpeed());
            myCar.Accelerate(20);

            // You can further use other methods and properties of the IVehicle interface here.

            Console.ReadLine(); // Keep console window open (for demonstration purposes)
        }
    }
}