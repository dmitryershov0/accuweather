using NUnit.Framework;
using System.Threading.Tasks;

namespace Accuweather.Tests
{
	public class Indices
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
		public async Task FiveDaysOfDailyIndexValues()
		{
			var resultJson = await _api.Indices.FiveDaysOfDailyIndexValues(178087, true);
			TestHelper.StatusCodeIsOk(resultJson);
		}

		[Test]
		public async Task TwelveHoursOfHourlyForecasts()
		{
			var resultJson =
			 await _api.Indices.FiveDaysOfDailyIndexValuesByGroupIndex(178087, 50, true);
			TestHelper.StatusCodeIsOk(resultJson);
		}

		[Test]
		public async Task FiveDaysOfDailyIndexValuesBySpecificIndex ()
		{
			var resultJson =
			 await _api.Indices.FiveDaysOfDailyIndexValuesBySpecificIndex(178087, 087, true);
			TestHelper.StatusCodeIsOk(resultJson);
		}
	}
}