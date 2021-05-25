// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

namespace BarbezDotEu.AlphaVantage.DTO
{
    /// <summary>
    /// Implements a base company data DTO that EXACTLY matches a query.
    /// </summary>
    public class BaseCompanyDataFullMatch
    {
        public BaseCompanyDataFullMatch(string currency, string marketClose, string marketOpen, string name, string region, string symbol, string timeZone, string type)
        {
            Currency = currency;
            MarketClose = marketClose;
            MarketOpen = marketOpen;
            Name = name;
            Region = region;
            Symbol = symbol;
            Timezone = timeZone;
            Type = type;
        }

        public string Symbol { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string MarketOpen { get; set; }

        public string MarketClose { get; set; }

        public string Timezone { get; set; }

        public string Currency { get; set; }

        public string Region { get; }
    }
}
