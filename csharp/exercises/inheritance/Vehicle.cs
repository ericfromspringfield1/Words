using System;

namespace Garage
{
    public class Vehicle
    {
        public Vehicle(string color, int speed)
        {
            MainColor = color;
            MaximumOccupancy = speed;
    }
    public Vehicle() //ask
    {

    }
    public string MainColor { get; set; }
    public int MaximumOccupancy { get; set; }
    public virtual void Drive()
    {
        Console.WriteLine("The vehicle makes little to low noise as it drives by");
    }
    public virtual void Turn()
    {
        Console.WriteLine("The vehicle makes a left turn on the NASCAR track");
    }

    public virtual void Stop()
    {

    }
    }
}





