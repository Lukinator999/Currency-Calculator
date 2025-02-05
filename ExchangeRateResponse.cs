using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace currency_calculator
{
    public class ExchangeRateResponse
    {
        public Dictionary<string, decimal> ConversionRates { get; set; }
    }
}
