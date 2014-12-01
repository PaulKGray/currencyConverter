using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace currencyConverter.Domain
{
    public class Currency
    {

        public Currency()
        {
            this.convertionRate = new List<ExchangeRate>();
        }

        /// <summary>
        /// holds the currency code
        /// </summary>
        public string currencyCode { get; set; }

        /// <summary>
        /// holds the conversion rate
        /// </summary>
        public List<ExchangeRate> convertionRate { get; set; }
    }
}
