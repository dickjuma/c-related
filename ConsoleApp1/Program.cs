using System.Drawing;

namespace InterfaceExample
{
    public interface IVehicle
    {
        int Doors
        {
            get;
            set;

        }
        int Wheels
        {
            get;
            set;

        }
         Color Vehiclecolor
        {
            get;
            set;
        }
        int Topspeed
        {
            get;
            set;

        }
        int Cylinders
        {
            get;
            set;
        }
        int HorsePower
        {
            get;
            set;
        }
        int Currentspeed
        {
            get;
          

        }
        string DisplayTopspeed();
        void Accelerate(int step);
    }
}
