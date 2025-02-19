using System.Collections.Generic;

namespace AverageExchangeRate.RatesProviders
{
	public class RatesTable
	{
		public string Table { get; set; }
		public string No { get; set; }
		public string EffectiveDate { get; set; }
		public List<ExchangeRate> Rates { get; set; }
	}
}
