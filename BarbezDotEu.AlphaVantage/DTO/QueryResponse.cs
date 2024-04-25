// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Linq;
using System.Text.Json.Serialization;

namespace BarbezDotEu.AlphaVantage.DTO
{
    /// <summary>
    /// Implements the query response contract as defined by Alpha Vantage.
    /// </summary>
    public class QueryResponse
    {
        /// <summary>
        /// Gets or sets the set of <see cref="BaseCompanyDataPartialMatch"/>es returned by the API.
        /// </summary>
        [JsonPropertyName("bestMatches")]
        public BaseCompanyDataPartialMatch[] Matches { get; set; } = [];

        /// <summary>
        /// Returns, if exists, a <see cref="BaseCompanyDataFullMatch"/> DTO containing the first result that is a 100% match. Returns NULL when no 100% match exists, or no results are returned.
        /// </summary>
        /// <returns>The <see cref="BaseCompanyDataFullMatch"/> equivalent of this <see cref="QueryResponse"/>.</returns>
        internal BaseCompanyDataFullMatch GetFirstOfDefaultAbsoluteMatch()
        {
            // We only care for a 100% match.
            var m = GetFirstAbsoluteMatch();
            return m?.AsFullMatch();
        }

        private BaseCompanyDataPartialMatch GetFirstAbsoluteMatch()
        {
            return Matches.FirstOrDefault(x => x.GetMatchScore() == 1);
        }
    }
}
