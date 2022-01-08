// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Threading.Tasks;
using BarbezDotEu.AlphaVantage.DTO;
using BarbezDotEu.AlphaVantage.Interfaces;
using BarbezDotEu.Provider;
using Microsoft.Extensions.Logging;

namespace BarbezDotEu.AlphaVantage.AlphaVantage
{
    /// <summary>
    /// Implements a data provider that connects to and can call Alpha Vantage APIs.
    /// </summary>
    public class AlphaVantageDataProvider : PoliteProvider, IAlphaVantageDataProvider
    {
        private AlphaVantageConfiguration configuration;
        private readonly MediaTypeWithQualityHeaderValue acceptHeader;

        /// <summary>
        /// Gets the <see cref="AlphaVantageConfiguration"/> this <see cref="AlphaVantageDataProvider"/> uses to communicate to the APIs.
        /// </summary>
        private AlphaVantageConfiguration Configuration
        {
            get
            {
                if (this.configuration == null)
                {
                    throw new ApplicationException(
                        $"An {nameof(AlphaVantageDataProvider)} cannot be used before it is configured. To fix, call the {nameof(AlphaVantageDataProvider)}.{nameof(Configure)} method right after initialization.");
                }

                return this.configuration;
            }
        }

        /// <summary>
        /// Constructs a <see cref="AlphaVantageDataProvider"/>.
        /// </summary>
        /// <param name="logger">A <see cref="ILogger"/> to use for logging.</param>
        /// <param name="httpClientFactory">The <see cref="IHttpClientFactory"/> to use.</param>
        public AlphaVantageDataProvider(ILogger logger, IHttpClientFactory httpClientFactory)
            : base(logger, httpClientFactory)
        {
            this.acceptHeader = new MediaTypeWithQualityHeaderValue("application/json");
        }

        /// <inheritdoc/>
        public void Configure(AlphaVantageConfiguration configuration)
        {
            this.configuration = configuration;
            this.SetRateLimitPerDay(configuration.MaxCallsPerDay);
        }

        /// <inheritdoc/>
        public async Task<BaseCompanyDataFullMatch> GetBaseCompanyDataFullyMatching(string symbol, bool retryOnError = true, double waitingMinutesBeforeRetry = 15)
        {
            var queryUrl = $"{this.Configuration.SymbolSearchUrl}{symbol.ToUpperInvariant()}";
            var request = new HttpRequestMessage(HttpMethod.Get, queryUrl);
            request.Headers.Accept.Add(acceptHeader);
            var result = await this.Request<QueryResponse>(request, retryOnError, waitingMinutesBeforeRetry);
            return result.Content?.GetFirstOfDefaultAbsoluteMatch();
        }

        /// <inheritdoc/>
        public async Task<BaseCompanyDataPartialMatch[]> GetBaseCompanyDataPartialMatches(string symbol, bool retryOnError = true, double waitingMinutesBeforeRetry = 15)
        {
            var queryUrl = $"{this.Configuration.SymbolSearchUrl}{symbol.ToUpperInvariant()}";
            var request = new HttpRequestMessage(HttpMethod.Get, queryUrl);
            request.Headers.Accept.Add(acceptHeader);
            var result = await this.Request<QueryResponse>(request, retryOnError, waitingMinutesBeforeRetry);
            return result.Content.Matches;
        }
    }
}
