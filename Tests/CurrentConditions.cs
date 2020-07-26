using NUnit.Framework;
using System.Threading.Tasks;

namespace Accuweather.Tests
{
	public class CurrentConditions
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
		public async Task GetTopCities()
		{
			var resultJson = await _api.CurrentConditions
			.GetTopCities(50);
			TestHelper.StatusCodeIsOk(resultJson);
		}

		[Test]
		public async Task Get()
		{
			var resultJson =
			 await _api.CurrentConditions.Get(178087, true);
			TestHelper.StatusCodeIsOk(resultJson);
		}

		[Test]
		public async Task GetHistorical24Hours()
		{
			var resultJson =
			 await _api.CurrentConditions.GetHistorical24Hours(178087, true);
			TestHelper.StatusCodeIsOk(resultJson);
		}

		[Test]
		public async Task GetHistorical6Hours()
		{
			var resultJson =
			 await _api.CurrentConditions.GetHistorical6Hours(178087, true);
			TestHelper.StatusCodeIsOk(resultJson);
		}
	}
}