// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System;
using System.Linq;
using System.Net.Http;
using System.Text.Json.Serialization;
using BarbezDotEu.Provider.Interfaces;

namespace BarbezDotEu.AlphaVantage.DTO
{
    /// <summary>
    /// Implements the query response contract as defined by AlphaVantage.
    /// </summary>
    public class QueryResponse : ICanFail
    {
        [JsonPropertyName("bestMatches")]
        public Match[] Matches { get; set; } = Array.Empty<Match>();

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
