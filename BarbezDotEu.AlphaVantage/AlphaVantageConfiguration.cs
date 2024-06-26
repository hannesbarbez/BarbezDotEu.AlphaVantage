﻿// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

// Quote from https://www.alphavantage.co/support/#support:
// "I have built a library/wrapper for Alpha Vantage with a specific programming language. May I open-source it on GitHub?
// Certainly - we truly appreciate the help and support from the community to make Alpha Vantage even more accessible and developer-friendly.
// However, we ask that your language-specific library/wrapper preserves the content of our JSON/CSV responses in both success and error cases.
// We consider it a top priority that our users get the original debugging and troubleshooting information from Alpha Vantage."
// 
// The latter is taken care of by BarbezDotEu.Provider, but should probably be improved upon as the functionality of this early-stage library is expanded upon.

namespace BarbezDotEu.AlphaVantage
{
    /// <summary>
    /// Implements and houses configuration parameters to correctly connect to and communicate with Alpha Vantage's services.
    /// </summary>
    /// <remarks>
    /// Constructs a new <see cref="AlphaVantageConfiguration"/> using all-default settings.
    /// </remarks>
    /// <param name="apiKey">The API key (to be requested via Alpha Vantage's website prior to using this library).</param>
    /// <param name="maxCallsPerDay">The maximum number of calls allowed per day.</param>
    public class AlphaVantageConfiguration(string apiKey, long maxCallsPerDay)
    {
        /// <summary>
        /// Gets the maximum number of calls allowed per day.
        /// </summary>
        public long MaxCallsPerDay { get; } = maxCallsPerDay;

        /// <summary>
        /// Gets the fully-qualified URL to use to search for symbols, including the API key. However, omits the actual search symbol.
        /// </summary>
        public string SymbolSearchUrl { get; } = $"https://www.alphavantage.co/query?function=SYMBOL_SEARCH&apikey={apiKey}&keywords=";
    }
}
