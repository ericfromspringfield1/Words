using System.Collections.Generic;

namespace refueling_station_garys_garage
{
    public class BatteryStation : IRefuel <Vehicle>
    {
        public List <Vehicle> vehicles {get; set;} = new List<Vehicle>();
        public int Capacity { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void Refuel(Vehicle vehicles)
        {
            throw new System.NotImplementedException();
        }

    }
}