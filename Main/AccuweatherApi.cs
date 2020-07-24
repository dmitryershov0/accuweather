using System;
using Accuweather.Locations;
using Accuweather.Current;

namespace Accuweather
{
    /// <summary>
    /// Accuweather Api client
    /// </summary>
    public class AccuweatherApi : IAccuweatherApi
    {
        private readonly string _apiKey;
        private readonly string _language;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey">Accuweather api key</param>
        /// <param name="language">Language</param>
        public AccuweatherApi(string apiKey, string language="en-us")
        {
            _apiKey = apiKey;
            _language = language;
        }
        private ILocationsApi _locations;

        /// <summary>
        /// The Locations API allows users to get a location key for their desired location.
        ///  This location key will then be used in the other APIs to retrieve weather data.
        /// </summary>
        /// <returns></returns>
        public ILocationsApi Locations => _locations ?? (_locations = new LocationsApi(_apiKey, _language));

        private ICurrentConditions _currentConditions;

        /// <summary>
        /// Get Current Conditions data for a specific location.
        /// </summary>
        /// <value></value>
        public ICurrentConditions CurrentConditions => _currentConditions ?? (_currentConditions = new CurrentConditions(_apiKey, _language));
        
    }
}
