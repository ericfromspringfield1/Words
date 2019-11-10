using System;

namespace Garage
{
    public class Ram : Vehicle
    {  // Gas powered truck
    public Ram(string color, double fuel, int maxOcc) 
        {
            FuelCapacity = fuel; //using this proptery from the base class. 
        }
    public double FuelCapacity { get; set; }
    // public void RefuelTank () { ... }
    public override void Drive () {
        Console.WriteLine($"The {this.MainColor} Ram growls by your mama!");
        Console.WriteLine($"My big ol truck can hold {this.FuelCapacity} gallons of United States fire juice");
    }
}
}
