// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using BarbezDotEu.AlphaVantage.DTO;
using BarbezDotEu.AlphaVantage.Interfaces;
using BarbezDotEu.Provider;
using Microsoft.Extensions.Logging;

namespace BarbezDotEu.AlphaVantage
{
    /// <summary>
    /// Implements a data provider that connects to and can call Alpha Vantage APIs.
    /// </summary>
    public class AlphaVantageDataProvider : PoliteProvider, IAlphaVantageDataProvider
    {
        private readonly AlphaVantageConfiguration configuration;
        private readonly MediaTypeWithQualityHeaderValue acceptHeader;

        /// <summary>
        /// Constructs a <see cref="AlphaVantageDataProvider"/>.
        /// </summary>
        /// <param name="logger">A <see cref="ILogger"/> to use for logging.</param>
        /// <param name="httpClientFactory">The <see cref="IHttpClientFactory"/> to use.</param>
        /// <param name="configuration">The <see cref="AlphaVantageConfiguration"/> to configure this <see cref="IAlphaVantageDataProvider"/> with.</param>
        public AlphaVantageDataProvider(ILogger logger, IHttpClientFactory httpClientFactory, AlphaVantageConfiguration configuration)
            : base(logger, httpClientFactory)
        {
            this.acceptHeader = new MediaTypeWithQualityHeaderValue("application/json");
            this.configuration = configuration;
            this.SetRateLimitPerDay(configuration.MaxCallsPerDay);
        }

        /// <inheritdoc/>
        public async Task<BaseCompanyDataFullMatch> GetBaseCompanyDataFullyMatching(string symbol, bool retryOnError = true, double waitingMinutesBeforeRetry = 15)
        {
            var queryUrl = $"{this.configuration.SymbolSearchUrl}{symbol.ToUpperInvariant()}";
            var request = new HttpRequestMessage(HttpMethod.Get, queryUrl);
            request.Headers.Accept.Add(acceptHeader);
            var result = await this.Request<QueryResponse>(request, retryOnError, waitingMinutesBeforeRetry);
            return result.Content?.GetFirstOfDefaultAbsoluteMatch();
        }

        /// <inheritdoc/>
        public async Task<BaseCompanyDataPartialMatch[]> GetBaseCompanyDataPartialMatches(string symbol, bool retryOnError = true, double waitingMinutesBeforeRetry = 15)
        {
            var queryUrl = $"{this.configuration.SymbolSearchUrl}{symbol.ToUpperInvariant()}";
            var request = new HttpRequestMessage(HttpMethod.Get, queryUrl);
            request.Headers.Accept.Add(acceptHeader);
            var result = await this.Request<QueryResponse>(request, retryOnError, waitingMinutesBeforeRetry);
            return result.Content.Matches;
        }
    }
}
