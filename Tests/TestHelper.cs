using NUnit.Framework;
using Newtonsoft.Json;
using Accuweather.Core.Models;
using System.Net;

namespace Accuweather.Tests {
	public static class TestHelper {
		public static string ApiKey => "YOUR_API_KEY";

		public static string Language => "en-us";
		
		public static void StatusCodeIsOk(string resultJson)
		{
			var result = JsonConvert.DeserializeObject<Response>(resultJson);
			Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
		}
	}
}