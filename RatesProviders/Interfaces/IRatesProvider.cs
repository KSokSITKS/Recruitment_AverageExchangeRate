using AverageExchangeRate.Data;
using System.Threading.Tasks;

namespace AverageExchangeRate.RatesProviders.Interfaces
{
	public interface IRatesProvider
    {
        Task<Rates> GetRatesAsync();
	}
}
