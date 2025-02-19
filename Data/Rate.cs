using System;

namespace AverageExchangeRate.Data
{
	public class Rate
	{
		public string Code { get; set; }
		public decimal RateValue { get; set; }

		public Rate(string code, decimal rateValue)
		{
			Code = code;
			RateValue = rateValue;
		}
	}
}
