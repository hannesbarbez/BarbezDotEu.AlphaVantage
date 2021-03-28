// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Threading.Tasks;
using BarbezDotEu.AlphaVantage.DTO;
using BarbezDotEu.AlphaVantage.Interfaces;
using BarbezDotEu.Provider;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace BarbezDotEu.AlphaVantage.AlphaVantage
{
    public class AlphaVantageDataProvider : PoliteProvider, IAlphaVantageDataProvider
    {
        private readonly string symbolSearchUrl;
        private readonly MediaTypeWithQualityHeaderValue acceptHeader;

        public AlphaVantageDataProvider(ILogger<IHostedService> logger, IConfiguration configuration, IHttpClientFactory httpClientFactory)
            : base(logger, httpClientFactory)
        {
            this.symbolSearchUrl = configuration["Alphavantage:UrlSymbolSearch"];
            this.SetRateLimitPerDay(configuration["Alphavantage:RateLimit:PerDay"]);
            this.acceptHeader = new MediaTypeWithQualityHeaderValue(MediaTypeNames.Application.Json);
        }

        public async Task<BaseCompanyData> GetBaseCompanyData(string symbol, bool retryOnError = true)
        {
            var queryUrl = $"{this.symbolSearchUrl}{symbol.ToUpperInvariant()}";
            var request = new HttpRequestMessage(HttpMethod.Get, queryUrl);
            request.Headers.Accept.Add(acceptHeader);
            var result = await this.Request<QueryResponse>(request);
            return result.AsBaseCompanyData();
        }
    }
}
