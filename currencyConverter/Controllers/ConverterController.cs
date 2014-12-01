using currencyConverter.CalculationEngine;
using currencyConverter.Domain;
using System.Web.Http;
using System.Net;
using currencyConverter.Respository;

namespace currencyConverter.Controllers
{
    public class ConverterController : ApiController
    {
        // GET api/converter/{currencyFrom}/{currencyTo}/{amount}
        public IHttpActionResult get(string currencyFrom, string currencyTo, float amount)
        {

            if (currencyFrom==currencyTo)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var convertionRequest = CurrencyCalculator.convert(currencyFrom, currencyTo, amount);

            LogRecorder.addNewLog(convertionRequest);

            return Ok(convertionRequest);
        }
    }
}