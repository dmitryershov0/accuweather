using Accuweather.Locations;
using Accuweather.Current;
using Accuweather.Forecast;
using Accuweather.Indices;

namespace Accuweather
{
	/// <summary>
	/// Accuweather Api
	/// </summary>
	public interface IAccuweatherApi
	{
		/// <summary>
		/// The Locations API allows users to get a location key for their desired location.
		/// This location key will then be used in the other APIs to retrieve weather data.
		/// </summary>
		/// <value></value>
		ILocationsApi Locations { get; }

		/// <summary>
		/// Get Current Conditions data for a specific location.
		/// </summary>
		/// <value></value>
		ICurrentConditions CurrentConditions { get; }

		/// <summary>
		/// Get forecast information for a specific location.
		/// </summary>
		/// <value></value>
		IForecast Forecast { get; }

		/// <summary>
		/// Get indices information for a specific location.
		/// </summary>
		/// <value></value>
		IIndices Indices { get; }
	}
}
