using AverageExchangeRate.Data;

namespace AverageExchangeRate.RatesProviders.Interfaces
{
    public interface IRatesProviderFactory
    {
        IRatesProvider CreateCurrentRatesProvider();
        IRatesProvider CreateArchivalRatesProvider(Month month, string year);
    }
}
