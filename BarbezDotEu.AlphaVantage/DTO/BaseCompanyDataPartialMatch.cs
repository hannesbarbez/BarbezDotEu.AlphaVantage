// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Globalization;
using System.Text.Json.Serialization;

namespace BarbezDotEu.AlphaVantage.DTO
{
    /// <summary>
    /// Implements a base company data DTO that matches a query either completely, or to a certain extent only.
    /// </summary>
    public class BaseCompanyDataPartialMatch
    {
        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        [JsonPropertyName("1. symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or sets the company name.
        /// </summary>
        [JsonPropertyName("2. name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonPropertyName("3. type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the region.
        /// </summary>
        [JsonPropertyName("4. region")]
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets the market open time.
        /// </summary>
        [JsonPropertyName("5. marketOpen")]
        public string MarketOpen { get; set; }

        /// <summary>
        /// Gets or sets the market close time.
        /// </summary>
        [JsonPropertyName("6. marketClose")]
        public string MarketClose { get; set; }

        /// <summary>
        /// Gets or sets the time zone.
        /// </summary>
        [JsonPropertyName("7. timezone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        [JsonPropertyName("8. currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets a percentage in which the result is a match in the context of a query.
        /// </summary>
        [JsonPropertyName("9. matchScore")]
        public string MatchScore { get; set; }

        /// <summary>
        /// Gets the <see cref="MatchScore"/> as a double.
        /// </summary>
        /// <returns>The <see cref="MatchScore"/> as a double.</returns>
        public double GetMatchScore()
        {
            var valid = double.TryParse(MatchScore, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out var result);
            if (valid)
            {
                return result;
            }

            return default;
        }

        /// <summary>
        /// Assumes an therefore returns this <see cref="BaseCompanyDataPartialMatch"/> is a <see cref="BaseCompanyDataFullMatch"/>.
        /// </summary>
        /// <returns>The <see cref="BaseCompanyDataFullMatch"/> representation of this <see cref="BaseCompanyDataPartialMatch"/>.</returns>
        public BaseCompanyDataFullMatch AsFullMatch()
        {
            return new BaseCompanyDataFullMatch(this.Currency, this.MarketClose, this.MarketOpen, this.Name, this.Region, this.Symbol, this.TimeZone, this.Type);
        }
    }
}
