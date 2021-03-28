// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Linq;
using System.Net.Http;
using BarbezDotEu.Provider.Interfaces;
using Newtonsoft.Json;

namespace BarbezDotEu.AlphaVantage.DTO
{
    /// <summary>
    /// Implements the query response contract as defined by AlphaVantage.
    /// </summary>
    public class QueryResponse : ICanFail
    {
        [JsonProperty("bestMatches")]
        public Match[] Matches { get; set; }

        /// <inheritdoc/>
        public HttpResponseMessage FailedResponse { get; set; }

        /// <inheritdoc/>
        public bool HasFailed => FailedResponse != null;

        /// <summary>
        /// Returns this provider-specific DTO to the shared DTO format for general use.
        /// </summary>
        /// <returns>The <see cref="BaseCompanyData"/> equivalent of this <see cref="QueryResponse"/>.</returns>
        internal BaseCompanyData AsBaseCompanyData()
        {
            // We only care for a 100% match.
            var m = GetFirstAbsoluteMatch();
            if (m == null)
                return null;

            return new BaseCompanyData(m.Currency, m.MarketClose, m.MarketOpen, m.Name, m.Region, m.Symbol, m.TimeZone, m.Type);
        }

        private Match GetFirstAbsoluteMatch()
        {
            return Matches.FirstOrDefault(x => x.GetMatchScore() == 1);
        }
    }
}
