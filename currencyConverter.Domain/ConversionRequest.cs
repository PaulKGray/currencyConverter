using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace currencyConverter.Domain
{
    public class ConversionRequest
    {
        /// <summary>
        /// currency to change from
        /// </summary>
        public string currencyFrom { get; set; }
        /// <summary>
        /// currency to change to
        /// </summary>
        public string currencyTo { get; set; }
        /// <summary>
        /// the amount to change
        /// </summary>
        public float amountToChange { get; set; }

        /// <summary>
        /// the amount returned
        /// </summary>
        public float amountConverted { get; set; }

        /// <summary>
        /// the rate applied
        /// </summary>
        public float rate { get; set; }


    }
}
