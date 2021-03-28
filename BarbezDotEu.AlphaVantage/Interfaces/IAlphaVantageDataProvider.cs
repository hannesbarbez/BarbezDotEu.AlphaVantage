// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Threading.Tasks;
using BarbezDotEu.AlphaVantage.DTO;
using BarbezDotEu.Provider.Interfaces;

namespace BarbezDotEu.AlphaVantage.Interfaces
{
    public interface IAlphaVantageDataProvider : IPoliteProvider
    {
        Task<BaseCompanyData> GetBaseCompanyData(string symbol, bool retryOnError = true);
    }
}
