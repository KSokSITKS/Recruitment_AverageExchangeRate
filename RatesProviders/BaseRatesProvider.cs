using AverageExchangeRate.Data;
using AverageExchangeRate.Exceptions;
using AverageExchangeRate.RatesProviders.Interfaces;
using Newtonsoft.Json;
using Serilog;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace AverageExchangeRate.RatesProviders
{
	public abstract class BaseRatesProvider : IRatesProvider
	{
		public abstract Task<Rates> GetRatesAsync();

		protected async Task<List<RatesTable>> GetRatesFromUrlAsync(string url)
		{
			var client = new HttpClient();
			var response = await client.GetAsync($"{url}/?format=json");

			Log.Information($"API at url: '{url}' returned response: '{JsonConvert.SerializeObject(response)}'");

			if (!response.IsSuccessStatusCode)
				throw new AverageExchangeRateAPIException("Wystąpił błąd podczas wczytywania danych z serwera.");

			var jsonResponse = await response.Content.ReadAsStringAsync();
			var ratesTables = JsonConvert.DeserializeObject<List<RatesTable>>(jsonResponse);

			return ratesTables;
		}
	}

}
