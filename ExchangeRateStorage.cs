using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace currency_calculator
{
    public static class ExchangeRateStorage
    {
        public static Dictionary<string, decimal> Rates { get; set; } = new Dictionary<string, decimal>();

        
        public static void UpdateRates(Dictionary<string, decimal> newRates)
        {
            Rates = newRates;
        }

        public static decimal GetRate(string currencyCode)
        {
            if (Rates.ContainsKey(currencyCode))
            {
                return Rates[currencyCode];
            }
            else
            {
                throw new KeyNotFoundException($"Wechselkurs für {currencyCode} nicht gefunden.");
            }
        }
    }

}
