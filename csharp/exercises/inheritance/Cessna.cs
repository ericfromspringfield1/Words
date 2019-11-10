using System;

namespace Garage
{
    public class Cessna : Vehicle
    {  // Propellor light aircraft
    public double FuelCapacity { get; set; }
    public void RefuelTank () {  }

    public override void Drive () 
    {
        Console.WriteLine("The Cessna say Zoooooom!");
    }
    
}
}