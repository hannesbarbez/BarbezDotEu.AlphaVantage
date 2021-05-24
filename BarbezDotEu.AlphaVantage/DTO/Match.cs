// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Globalization;
using System.Text.Json.Serialization;

namespace BarbezDotEu.AlphaVantage.DTO
{
    public class Match
    {
        [JsonPropertyName("1. symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("2. name")]
        public string Name { get; set; }

        [JsonPropertyName("3. type")]
        public string Type { get; set; }

        [JsonPropertyName("4. region")]
        public string Region { get; set; }

        [JsonPropertyName("5. marketOpen")]
        public string MarketOpen { get; set; }

        [JsonPropertyName("6. marketClose")]
        public string MarketClose { get; set; }

        [JsonPropertyName("7. timezone")]
        public string TimeZone { get; set; }

        [JsonPropertyName("8. currency")]
        public string Currency { get; set; }

        [JsonPropertyName("9. matchScore")]
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
