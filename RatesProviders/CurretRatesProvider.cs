using AverageExchangeRate.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AverageExchangeRate.RatesProviders
{
	public class CurretRatesProvider : BaseRatesProvider
    {
        private static CurretRatesProvider singleton;

        private CurretRatesProvider() { }

        public static CurretRatesProvider Create()
        {
            if (singleton == null)
                singleton = new CurretRatesProvider();

            return singleton;
        }

		public override async Task<Rates> GetRatesAsync()
		{
            var ratesTable = await this.GetRatesFromUrlAsync("https://api.nbp.pl/api/exchangerates/tables/a/today"); ;
            var rateList = ratesTable
                .Single()
                .Rates
                .Select(rate => new Rate(rate.Code, rate.Mid))
                .ToList();

            return new Rates(rateList);
		}
	}
}
