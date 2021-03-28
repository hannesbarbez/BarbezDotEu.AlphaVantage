// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Globalization;
using Newtonsoft.Json;

namespace BarbezDotEu.AlphaVantage.DTO
{
    public class Match
    {
        [JsonProperty("1. symbol")]
        public string Symbol { get; set; }

        [JsonProperty("2. name")]
        public string Name { get; set; }

        [JsonProperty("3. type")]
        public string Type { get; set; }

        [JsonProperty("4. region")]
        public string Region { get; set; }

        [JsonProperty("5. marketOpen")]
        public string MarketOpen { get; set; }

        [JsonProperty("6. marketClose")]
        public string MarketClose { get; set; }

        [JsonProperty("7. timezone")]
        public string TimeZone { get; set; }

        [JsonProperty("8. currency")]
        public string Currency { get; set; }

        [JsonProperty("9. matchScore")]
        public string MatchScore { get; set; }

        public double GetMatchScore()
        {
            var valid = double.TryParse(MatchScore, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out var result);
            if (valid)
            {
                return result;
            }

            return default;
        }
    }
}
