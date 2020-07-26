using NUnit.Framework;
using Accuweather.Locations;
using Accuweather.Locations.Enums;
using System.Threading.Tasks;
using Accuweather;

namespace Accuweather.Tests
{
	public class Forecast
	{
		private IAccuweatherApi _api;

		[SetUp]
		public void Init()
		{
			var apiKey = TestHelper.ApiKey;
			var language = TestHelper.Language;
			_api = new AccuweatherApi(apiKey, language);
		}

		[Test]
		public async Task FiveDaysOfDailyForecasts()
		{
			var resultJson = await _api.Forecast.FiveDaysOfDailyForecasts(178087, true, true);
			TestHelper.StatusCodeIsOk(resultJson);
		}

		[Test]
		public async Task TwelveHoursOfHourlyForecasts()
		{
			var resultJson = await _api.Forecast.TwelveHoursOfHourlyForecasts(178087, true, true);
			TestHelper.StatusCodeIsOk(resultJson);
		}
	}
}