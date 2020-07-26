using System;
using Accuweather.Locations;
using Accuweather.Current;
using Accuweather.Indices;
using Accuweather.Forecast;

namespace Accuweather
{
	/// <inheritdoc cref="IAccuweatherApi"/>
	public class AccuweatherApi : IAccuweatherApi
	{
		private readonly string _apiKey;
		private readonly string _language;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="apiKey">Accuweather api key</param>
		/// <param name="language">Language</param>
		public AccuweatherApi(string apiKey, string language = "en-us")
		{
			_apiKey = apiKey;
			_language = language;
		}
		private ILocationsApi _locations;

		///<inheritdoc cref="IAccuweatherApi.Locations"/>
		public ILocationsApi Locations => _locations ?? (_locations = new LocationsApi(_apiKey, _language));

		private ICurrentConditions _currentConditions;

		///<inheritdoc cref="IAccuweatherApi.CurrentConditions"/>
		public ICurrentConditions CurrentConditions => _currentConditions ?? (_currentConditions = new CurrentConditions(_apiKey, _language));

		private IForecast _forecast;

		///<inheritdoc cref="IAccuweatherApi.Forecast"/>
		public IForecast Forecast => _forecast ?? (_forecast = new Forecast.Forecast(_apiKey, _language));

		private IIndices _indices;

		///<inheritdoc cref="IAccuweatherApi.Indices"/>
		public IIndices Indices => _indices ?? (_indices = new Indices.Indices(_apiKey, _language));

	}
}
