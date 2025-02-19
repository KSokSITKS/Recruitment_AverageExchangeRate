using System.Collections.Generic;
using System.Linq;

namespace AverageExchangeRate.Data
{
	public class Rates
	{
		public IReadOnlyList<Rate> RateList { get; }

		public Rates(IEnumerable<Rate> rateList)
		{
			this.RateList = rateList.ToList();
		}
	}
}
