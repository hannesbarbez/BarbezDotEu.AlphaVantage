// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Threading.Tasks;
using BarbezDotEu.AlphaVantage.DTO;
using BarbezDotEu.Provider.Interfaces;

namespace BarbezDotEu.AlphaVantage.Interfaces
{
    /// <summary>
    /// Defines a blueprint for a data provider that connects to and can call Alpha Vantage APIs.
    /// </summary>
    public interface IAlphaVantageDataProvider : IPoliteProvider
    {
        /// <summary>
        /// Configures this <see cref="IAlphaVantageDataProvider"/> so that it can successfully communicate with the Alpha Vantage APIs.
        /// </summary>
        /// <param name="alphaVantageConfiguration">The <see cref="AlphaVantageConfiguration"/> to configure this <see cref="IAlphaVantageDataProvider"/> with.</param>
        /// <remarks>
        /// Configuration is required before any APIs can be called.
        /// </remarks>
        void Configure(AlphaVantageConfiguration alphaVantageConfiguration);

        /// <summary>
        /// Gets base company data for a given symbol that EXACTLY matches a query.
        /// Returns, if exists, a <see cref="BaseCompanyDataFullMatch"/> DTO containing the first result that is a 100% match. Returns NULL when no 100% match exists, or when no results were returned from the API.
        /// </summary>
        /// <param name="symbol">The symbol to return data for.</param>
        /// <param name="retryOnError">Set to TRUE to retry the request, in case the initial request should prove unsuccessful.</param>
        /// <param name="waitingMinutesBeforeRetry">The number of minutes to wait before automatically retrying re-sending the request, if the intention is to retry again upon error.</param>
        /// <returns>The requested <see cref="BaseCompanyDataFullMatch"/>.</returns>
        Task<BaseCompanyDataFullMatch> GetBaseCompanyDataFullyMatching(string symbol, bool retryOnError = true, double waitingMinutesBeforeRetry = 15);

        /// <summary>
        /// Gets base company data DTO that matches a query either completely, or to a certain extent only.
        /// </summary>
        /// <param name="symbol">The symbol to return data for.</param>
        /// <param name="retryOnError">Set to TRUE to retry the request, in case the initial request should prove unsuccessful.</param>
        /// <param name="waitingMinutesBeforeRetry">The number of minutes to wait before automatically retrying re-sending the request, if the intention is to retry again upon error.</param>
        /// <returns>The requested <see cref="BaseCompanyDataFullMatch"/>es.</returns>
        Task<BaseCompanyDataPartialMatch[]> GetBaseCompanyDataPartialMatches(string symbol, bool retryOnError = true, double waitingMinutesBeforeRetry = 15);
    }
}
