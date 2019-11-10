using System;

namespace Garage
{
    public class Tesla : Vehicle
    {  // Electric car
    public Tesla(string color, double charge, int speed) 
        {
            BatteryKWh = charge; //using this proptery from the base class. 
            MaximumOccupancy = speed;
        }
    public double BatteryKWh { get; set; }

    public void ChargeBattery() {  }

    public override void Drive() 
    {
        Console.WriteLine($"The {this.MainColor} Tesla hums by you with its electric zoom!");
        Console.WriteLine($"The battery has about {this.BatteryKWh} jeejoos of juice remaining");
    }
    public override void Stop()
    {
        Console.WriteLine($"The {this.MainColor} Tesla is stopped by the far right");
        Console.WriteLine($"This Tesla stops after it hits {this.MaximumOccupancy}");
    }
}
}
    