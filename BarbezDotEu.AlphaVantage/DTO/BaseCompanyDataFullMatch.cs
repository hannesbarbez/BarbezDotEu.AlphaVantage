// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

namespace BarbezDotEu.AlphaVantage.DTO
{
    /// <summary>
    /// Implements a base company data DTO that EXACTLY matches a query.
    /// </summary>
    public class BaseCompanyDataFullMatch
    {
        /// <summary>
        /// Constructs a new <see cref="BaseCompanyDataFullMatch"/>.
        /// </summary>
        /// <param name="currency">The currency.</param>
        /// <param name="marketClose">When the market closes.</param>
        /// <param name="marketOpen">When the market opens.</param>
        /// <param name="name">The name of the company.</param>
        /// <param name="region">The region the company is located in.</param>
        /// <param name="symbol">The company's ticker symbol.</param>
        /// <param name="timeZone">The timezone.</param>
        /// <param name="type">The type.</param>
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

        /// <summary>
        /// Gets or sets the company's symbol.
        /// </summary>
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or sets the company name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets when the market opens.
        /// </summary>
        public string MarketOpen { get; set; }

        /// <summary>
        /// Gets or sets when the market closes.
        /// </summary>
        public string MarketClose { get; set; }

        /// <summary>
        /// Gets or sets the timezone.
        /// </summary>
        public string Timezone { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets the region.
        /// </summary>
        public string Region { get; }
    }
}
