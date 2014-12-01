using currencyConverter.Domain;
using System;
using System.Linq;

namespace currencyConverter.CalculationEngine
{
    public static class CurrencyCalculator
    {
        public static ConversionRequest convert(string from, string to, float amount)
        {
            var convertionRequest = new ConversionRequest();

            var data = DataSetup.setUpDummyData();

            var rate = data.First(x => x.currencyCode == from).convertionRate.First(x => x.currencyTo == to).rate;

            convertionRequest.currencyFrom = from;
            convertionRequest.currencyTo = to;
            convertionRequest.rate = rate;
            convertionRequest.amountToChange = amount;
            convertionRequest.amountConverted = amount * rate;    

            return convertionRequest;
  
        }

    }
}
