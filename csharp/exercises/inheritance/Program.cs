using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Move all common properties in your vehicles to a new Vehicle class.
        // Create an instance of each vehicle.
        // Define a different value for each vehicle's properties.
        // Create a Drive() method in the Vehicle class.
        // Override the Drive() method in all the other vehicle classes. Include the vehicle's color in the message (i.e.   "The blue Ram drives past. RRrrrrrummbbble!").
            Ram ram = new Ram("Sunset Blue", 19.13, 7);
            Tesla tesla = new Tesla("Toilet Water Gray", 78.0, 8);
            
            
            ram.Drive();
            tesla.Drive();
            tesla.Stop();
            tesla.Turn();
            Console.WriteLine();

            

        }

    }
}





