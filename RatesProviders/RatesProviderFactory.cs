using AverageExchangeRate.Data;
using AverageExchangeRate.Exceptions;
using AverageExchangeRate.RatesProviders.Interfaces;
using System.Text.RegularExpressions;

namespace AverageExchangeRate.RatesProviders
{
    public class RatesProviderFactory : IRatesProviderFactory
    {
        public IRatesProvider CreateCurrentRatesProvider()
        {
            return CurretRatesProvider.Create();
        }

        public IRatesProvider CreateArchivalRatesProvider(Month month, string year)
        {
            ValidateYear(year);

            return new ArchivalRatesProvider(month, year);
        }

        private void ValidateYear(string year)
        {
            if (string.IsNullOrWhiteSpace(year))
                throw new AverageExchangeRateInvalidArgumentException("Podana data jest pusta");

            var isIncorrectlyFromated = !Regex.IsMatch(year, @"\b\d{4}\b");

            if (isIncorrectlyFromated)
                throw new AverageExchangeRateInvalidArgumentException("Zły format daty. Przykład poprawnej daty: 2025");
        }
    }
}
