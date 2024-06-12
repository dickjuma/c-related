
using System.Drawing;

namespace InterfaceExample
{
    public class Motorcycle : IVehicle
    {
        private int _currentspeed = 0;
        public int Doors
        {
            get;
            set;

        }
        public int Wheels
        {
            get;
            set;

        }
        public Color Vehiclecolor
        {
            get;
            set;
        }
        public int Topspeed
        {
            get;
            set;

        }
        public int Cylinders
        {
            get;
            set;
        }
        public int HorsePower
        {
            get;
            set;
        }
        public int Currentspeed
        {
            get
            {
                return _currentspeed;
            }
        }
        public Motorcycle(int doors, int wheels, Color color, int topspeed, int horsePower, int cylinder, int currentspeed)
        {
            this.Doors = doors;
            this.Wheels = wheels;
            this.Vehiclecolor = color;
            this.Topspeed = topspeed;
            this.Cylinders = cylinder;
            this._currentspeed = currentspeed;
            this.HorsePower = horsePower;
        }
        public string DisplayTopspeed()
        {
            return "Top speed :" + this.Topspeed;
        }
        public void Accelerate(int step)
        {
            this._currentspeed += step;
        }
    }
}
    


  