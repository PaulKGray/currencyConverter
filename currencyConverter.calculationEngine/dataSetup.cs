

using currencyConverter.Domain;
using System.Collections.Generic;
namespace currencyConverter.CalculationEngine
{
    /// <summary>
    /// Sets up dummy data
    /// </summary>
    public static class DataSetup
    {

        /// <summary>
        /// Creates the domain conversion rate
        /// </summary>
        /// <returns>List Currency</returns>
        public static List<Currency> setUpDummyData()
        {

            var dummyData = new List<Currency>();

            var gbpData = new Currency { currencyCode = "GBP" };
            gbpData.convertionRate.Add(new ExchangeRate { currencyTo = "USD", rate = 1.2F });
            gbpData.convertionRate.Add(new ExchangeRate { currencyTo = "AUD", rate = 1.9F });
            gbpData.convertionRate.Add(new ExchangeRate { currencyTo = "EUR", rate = 1.7F });
            dummyData.Add(gbpData);


            var usdData = new Currency { currencyCode = "USD" };
            usdData.convertionRate.Add(new ExchangeRate { currencyTo = "GBP", rate = 0.9F });
            usdData.convertionRate.Add(new ExchangeRate { currencyTo = "AUD", rate = 1.2F });
            usdData.convertionRate.Add(new ExchangeRate { currencyTo = "EUR", rate = 1.1F });
            dummyData.Add(usdData);


            var audData = new Currency { currencyCode = "AUD" };
            audData.convertionRate.Add(new ExchangeRate { currencyTo = "GBP", rate = 0.4F });
            audData.convertionRate.Add(new ExchangeRate { currencyTo = "USD", rate = 0.9F });
            audData.convertionRate.Add(new ExchangeRate { currencyTo = "EUR", rate = 0.8F });
            dummyData.Add(audData);

            var eurData = new Currency { currencyCode = "EUR" };
            eurData.convertionRate.Add(new ExchangeRate { currencyTo = "GBP", rate = 0.8F });
            eurData.convertionRate.Add(new ExchangeRate { currencyTo = "USD", rate = 1.4F });
            eurData.convertionRate.Add(new ExchangeRate { currencyTo = "AUD", rate = 1.1F });
            dummyData.Add(eurData);


            return dummyData;

        }



    }
}
