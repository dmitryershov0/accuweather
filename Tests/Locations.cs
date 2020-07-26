using NUnit.Framework;
using Accuweather.Locations;
using Accuweather.Locations.Enums;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Accuweather.Core.Models;
using System.Net;
using Accuweather;

namespace Accuweather.Tests
{
	public class Locations
	{
		private IAccuweatherApi _api;

		[SetUp]
		public void Init()
		{
			var apiKey = "YOUR_API_KEY";
			_api = new AccuweatherApi(apiKey, "ru-ru");
		}

		#region  Private
		static object[] Offsets = {
			null,
			25
		};

		private void StatusCodeIsOk(string resultJson)
		{
			var result = JsonConvert.DeserializeObject<Response>(resultJson);
			Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
		}
		#endregion

		#region  Tests

		[Test, TestCaseSource("Offsets")]
		public async Task GetAreaList(int? offset)
		{
			var resultJson = await _api.Locations.GetAreaList("RU", offset);
			StatusCodeIsOk(resultJson);
		}

		[Test]
		public async Task GetCountryList()
		{
			var resultJson = await _api.Locations.GetCountryList("RU");
			StatusCodeIsOk(resultJson);
		}

		[Test]
		public async Task GetRegionList()
		{
			var resultJson = await _api.Locations.GetRegionList();
			StatusCodeIsOk(resultJson);
		}

		[Test]
		public async Task GetTopCitiesList()
		{
			var resultJson = await _api.Locations.GetTopCitiesList(50, true);
			StatusCodeIsOk(resultJson);
		}

		[Test]
		public async Task AutoCompleteSearch()
		{
			var resultJson = await _api.Locations.AutoCompleteSearch("russia");
			StatusCodeIsOk(resultJson);
		}

		[Test]
		public async Task SearchByLocationKey()
		{
			var resultJson = await _api.Locations.SearchByLocationKey("178087", true);
			StatusCodeIsOk(resultJson);
		}

		[Test]
		public async Task GetCityNeighbors()
		{
			var resultJson = await _api.Locations.GetCityNeighbors("178087", true);
			StatusCodeIsOk(resultJson);
		}

		[Test]
		public async Task CitySearch()
		{
			var resultJson = await _api.Locations.CitySearch("Novosibirsk", true);
			StatusCodeIsOk(resultJson);
		}

		[Test]
		public async Task CitySearchWithCountryCode()
		{
			var resultJson = await _api.Locations.CitySearch("RU", "Novosibirsk", true);
			StatusCodeIsOk(resultJson);
		}

		[Test]
		public async Task CitySearchWithCountryAndAdminCodes()
		{
			var resultJson = await _api.Locations.CitySearch("RU", "NVS", "Novosibirsk", true);
			StatusCodeIsOk(resultJson);
		}

		[Test]
		public async Task PointsOfInterestSearch()
		{
			var resultJson = await _api.Locations.PointsOfInterestSearch("FAA", POI.Airports, true);
			StatusCodeIsOk(resultJson);
		}

		[Test]
		public async Task PointsOfInterestSearchWithCountryCode()
		{
			var resultJson = await _api.Locations.PointsOfInterestSearch("RU", "OVB", POI.Airports, true);
			StatusCodeIsOk(resultJson);
		}

		[Test]
		public async Task PointsOfInterestSearchWithCountryAndAdminCodes()
		{
			var resultJson = await _api.Locations.PointsOfInterestSearch("RU", "NVS", "OVB", POI.Airports, true);
			StatusCodeIsOk(resultJson);
		}

		[Test]
		public async Task PostalCodeSearchWithCountryCode()
		{
			var resultJson = await _api.Locations.PostalCodeSearch("DE", "10178", true);
			StatusCodeIsOk(resultJson);
		}

		[Test]
		public async Task PostalCodeSearch()
		{
			var resultJson = await _api.Locations.PostalCodeSearch("10178", true);
			StatusCodeIsOk(resultJson);
		}

		[Test]
		public async Task TextSearch()
		{
			var resultJson = await _api.Locations.TextSearch("Barnaul", true, 25);
			StatusCodeIsOk(resultJson);
		}

		[Test]
		public async Task TextSearchWithCountryCode()
		{
			var resultJson = await _api.Locations.TextSearch("RU", "Barnaul", true, 25);
			StatusCodeIsOk(resultJson);
		}

		[Test]
		public async Task TextSearchWithCountryAndAdminCodes()
		{
			var resultJson = await _api.Locations.TextSearch("RU", "ALT", "Barnaul", true, 25);
			StatusCodeIsOk(resultJson);
		}

		[Test]
		public async Task GeoPositionSearch()
		{
			var resultJson = await _api.Locations.GeoPositionSearch(53.347, 83.778, true);
			StatusCodeIsOk(resultJson);
		}

		[Test]
		public async Task IpAddressSearch()
		{
			var resultJson = await _api.Locations.IpAddressSearch("188.162.229.117", true);
			StatusCodeIsOk(resultJson);
		}


		#endregion Tests
	}
}