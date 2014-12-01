using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace currencyConverter.Domain
{
    /// <summary>
    /// The rate of which a currency is converted
    /// </summary>
    public class ExchangeRate
    {
        /// <summary>
        /// the currency being converted to
        /// </summary>
        public string currencyTo { get; set; }

        /// <summary>
        /// the rate of the conversion
        /// </summary>
        public float rate { get; set; }


    }
}
