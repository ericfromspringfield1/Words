using System.Collections.Generic;

namespace ElectronicInterfaces
{
    public interface IRadio
    {
         double CurrentFrequency { get; set; }
         List<double> FavoriteStations { get; set; }
         bool IsRadioOn { get; set; }
         void AddFavorite(double station)
         void RemoveFavorite()
        {

        }



    }

}

