using AverageExchangeRate.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AverageExchangeRate.RatesProviders
{
	public class ArchivalRatesProvider : BaseRatesProvider
    {
        private readonly Month month;
        private readonly string year;

        public ArchivalRatesProvider(Month month, string year)
        {
            this.month = month;
            this.year = year;
        }

		public override async Task<Rates> GetRatesAsync()
		{
			var monthNumber = (int)month;
			var yearNumber = int.Parse(year);
			var monthStartDate = new DateTime(yearNumber, monthNumber, 1);
			var monthEndDate = monthStartDate.AddMonths(1).AddDays(-1);

			var url = $"https://api.nbp.pl/api/exchangerates/tables/a/{this.FormatDate(monthStartDate)}/{this.FormatDate(monthEndDate)}";
			var ratesTables = await this.GetRatesFromUrlAsync(url);
			var averageRatesForTheMonth = this.GetAverageRates(ratesTables);

			return averageRatesForTheMonth;
		}

		private Rates GetAverageRates(List<RatesTable> ratesTables)
		{
			var avgCurrencyExchangeRatesInMonth = ratesTables
				.SelectMany(rateTable => rateTable.Rates)
				.GroupBy(exchangeRate => exchangeRate.Code)
				.Select(currencyExchangeRatesInMonth => 
					new Rate(
						currencyExchangeRatesInMonth.Key, 
						currencyExchangeRatesInMonth.Select(exRate => exRate.Mid).Average()
						)
				)
				.ToList();

			return new Rates(avgCurrencyExchangeRatesInMonth);
		}

		private string FormatDate(DateTime date)
		{
			return date.ToString("yyyy-MM-dd");
		}
	}
}
