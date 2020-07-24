using Accuweather.Locations;

namespace Accuweather
{
    /// <summary>
    /// Accuweather Api interface
    /// </summary>
    public interface IAccuweatherApi
    {
        /// <summary>
        /// The Locations API allows users to get a location key for their desired location.
        /// This location key will then be used in the other APIs to retrieve weather data.
        /// </summary>
        /// <value></value>
        ILocationsApi Locations {get;}
    }
}
