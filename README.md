<a name='assembly'></a>
# BarbezDotEu.AlphaVantage
An unofficial, modern, very much work-in-progress client for Alpha Vantage APIs.

The binaries are available as a NuGet package from https://www.nuget.org/packages/BarbezDotEu.AlphaVantage/ or via e.g. Visual Studio's NuGet package manager.

## Contents

- [AlphaVantageConfiguration](#T-BarbezDotEu-AlphaVantage-AlphaVantageConfiguration 'BarbezDotEu.AlphaVantage.AlphaVantageConfiguration')
  - [#ctor(maxCallsPerDay,symbolSearchUrl)](#M-BarbezDotEu-AlphaVantage-AlphaVantageConfiguration-#ctor-System-String,System-String- 'BarbezDotEu.AlphaVantage.AlphaVantageConfiguration.#ctor(System.String,System.String)')
  - [#ctor(maxCallsPerDay,symbolSearchUrl)](#M-BarbezDotEu-AlphaVantage-AlphaVantageConfiguration-#ctor-System-Int64,System-String- 'BarbezDotEu.AlphaVantage.AlphaVantageConfiguration.#ctor(System.Int64,System.String)')
  - [#ctor(apiKey)](#M-BarbezDotEu-AlphaVantage-AlphaVantageConfiguration-#ctor-System-String- 'BarbezDotEu.AlphaVantage.AlphaVantageConfiguration.#ctor(System.String)')
  - [MaxCallsPerDay](#P-BarbezDotEu-AlphaVantage-AlphaVantageConfiguration-MaxCallsPerDay 'BarbezDotEu.AlphaVantage.AlphaVantageConfiguration.MaxCallsPerDay')
  - [SymbolSearchUrl](#P-BarbezDotEu-AlphaVantage-AlphaVantageConfiguration-SymbolSearchUrl 'BarbezDotEu.AlphaVantage.AlphaVantageConfiguration.SymbolSearchUrl')
- [AlphaVantageDataProvider](#T-BarbezDotEu-AlphaVantage-AlphaVantage-AlphaVantageDataProvider 'BarbezDotEu.AlphaVantage.AlphaVantage.AlphaVantageDataProvider')
  - [#ctor(logger,httpClientFactory)](#M-BarbezDotEu-AlphaVantage-AlphaVantage-AlphaVantageDataProvider-#ctor-Microsoft-Extensions-Logging-ILogger,System-Net-Http-IHttpClientFactory- 'BarbezDotEu.AlphaVantage.AlphaVantage.AlphaVantageDataProvider.#ctor(Microsoft.Extensions.Logging.ILogger,System.Net.Http.IHttpClientFactory)')
  - [Configuration](#P-BarbezDotEu-AlphaVantage-AlphaVantage-AlphaVantageDataProvider-Configuration 'BarbezDotEu.AlphaVantage.AlphaVantage.AlphaVantageDataProvider.Configuration')
  - [Configure()](#M-BarbezDotEu-AlphaVantage-AlphaVantage-AlphaVantageDataProvider-Configure-BarbezDotEu-AlphaVantage-AlphaVantageConfiguration- 'BarbezDotEu.AlphaVantage.AlphaVantage.AlphaVantageDataProvider.Configure(BarbezDotEu.AlphaVantage.AlphaVantageConfiguration)')
  - [GetBaseCompanyDataFullyMatching()](#M-BarbezDotEu-AlphaVantage-AlphaVantage-AlphaVantageDataProvider-GetBaseCompanyDataFullyMatching-System-String,System-Boolean,System-Double- 'BarbezDotEu.AlphaVantage.AlphaVantage.AlphaVantageDataProvider.GetBaseCompanyDataFullyMatching(System.String,System.Boolean,System.Double)')
  - [GetBaseCompanyDataPartialMatches()](#M-BarbezDotEu-AlphaVantage-AlphaVantage-AlphaVantageDataProvider-GetBaseCompanyDataPartialMatches-System-String,System-Boolean,System-Double- 'BarbezDotEu.AlphaVantage.AlphaVantage.AlphaVantageDataProvider.GetBaseCompanyDataPartialMatches(System.String,System.Boolean,System.Double)')
- [BaseCompanyDataFullMatch](#T-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataFullMatch 'BarbezDotEu.AlphaVantage.DTO.BaseCompanyDataFullMatch')
  - [#ctor(currency,marketClose,marketOpen,name,region,symbol,timeZone,type)](#M-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataFullMatch-#ctor-System-String,System-String,System-String,System-String,System-String,System-String,System-String,System-String- 'BarbezDotEu.AlphaVantage.DTO.BaseCompanyDataFullMatch.#ctor(System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String)')
  - [Currency](#P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataFullMatch-Currency 'BarbezDotEu.AlphaVantage.DTO.BaseCompanyDataFullMatch.Currency')
  - [MarketClose](#P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataFullMatch-MarketClose 'BarbezDotEu.AlphaVantage.DTO.BaseCompanyDataFullMatch.MarketClose')
  - [MarketOpen](#P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataFullMatch-MarketOpen 'BarbezDotEu.AlphaVantage.DTO.BaseCompanyDataFullMatch.MarketOpen')
  - [Name](#P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataFullMatch-Name 'BarbezDotEu.AlphaVantage.DTO.BaseCompanyDataFullMatch.Name')
  - [Region](#P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataFullMatch-Region 'BarbezDotEu.AlphaVantage.DTO.BaseCompanyDataFullMatch.Region')
  - [Symbol](#P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataFullMatch-Symbol 'BarbezDotEu.AlphaVantage.DTO.BaseCompanyDataFullMatch.Symbol')
  - [Timezone](#P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataFullMatch-Timezone 'BarbezDotEu.AlphaVantage.DTO.BaseCompanyDataFullMatch.Timezone')
  - [Type](#P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataFullMatch-Type 'BarbezDotEu.AlphaVantage.DTO.BaseCompanyDataFullMatch.Type')
- [BaseCompanyDataPartialMatch](#T-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataPartialMatch 'BarbezDotEu.AlphaVantage.DTO.BaseCompanyDataPartialMatch')
  - [Currency](#P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataPartialMatch-Currency 'BarbezDotEu.AlphaVantage.DTO.BaseCompanyDataPartialMatch.Currency')
  - [MarketClose](#P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataPartialMatch-MarketClose 'BarbezDotEu.AlphaVantage.DTO.BaseCompanyDataPartialMatch.MarketClose')
  - [MarketOpen](#P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataPartialMatch-MarketOpen 'BarbezDotEu.AlphaVantage.DTO.BaseCompanyDataPartialMatch.MarketOpen')
  - [MatchScore](#P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataPartialMatch-MatchScore 'BarbezDotEu.AlphaVantage.DTO.BaseCompanyDataPartialMatch.MatchScore')
  - [Name](#P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataPartialMatch-Name 'BarbezDotEu.AlphaVantage.DTO.BaseCompanyDataPartialMatch.Name')
  - [Region](#P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataPartialMatch-Region 'BarbezDotEu.AlphaVantage.DTO.BaseCompanyDataPartialMatch.Region')
  - [Symbol](#P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataPartialMatch-Symbol 'BarbezDotEu.AlphaVantage.DTO.BaseCompanyDataPartialMatch.Symbol')
  - [TimeZone](#P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataPartialMatch-TimeZone 'BarbezDotEu.AlphaVantage.DTO.BaseCompanyDataPartialMatch.TimeZone')
  - [Type](#P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataPartialMatch-Type 'BarbezDotEu.AlphaVantage.DTO.BaseCompanyDataPartialMatch.Type')
  - [AsFullMatch()](#M-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataPartialMatch-AsFullMatch 'BarbezDotEu.AlphaVantage.DTO.BaseCompanyDataPartialMatch.AsFullMatch')
  - [GetMatchScore()](#M-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataPartialMatch-GetMatchScore 'BarbezDotEu.AlphaVantage.DTO.BaseCompanyDataPartialMatch.GetMatchScore')
- [IAlphaVantageDataProvider](#T-BarbezDotEu-AlphaVantage-Interfaces-IAlphaVantageDataProvider 'BarbezDotEu.AlphaVantage.Interfaces.IAlphaVantageDataProvider')
  - [Configure(alphaVantageConfiguration)](#M-BarbezDotEu-AlphaVantage-Interfaces-IAlphaVantageDataProvider-Configure-BarbezDotEu-AlphaVantage-AlphaVantageConfiguration- 'BarbezDotEu.AlphaVantage.Interfaces.IAlphaVantageDataProvider.Configure(BarbezDotEu.AlphaVantage.AlphaVantageConfiguration)')
  - [GetBaseCompanyDataFullyMatching(symbol,retryOnError,waitingMinutesBeforeRetry)](#M-BarbezDotEu-AlphaVantage-Interfaces-IAlphaVantageDataProvider-GetBaseCompanyDataFullyMatching-System-String,System-Boolean,System-Double- 'BarbezDotEu.AlphaVantage.Interfaces.IAlphaVantageDataProvider.GetBaseCompanyDataFullyMatching(System.String,System.Boolean,System.Double)')
  - [GetBaseCompanyDataPartialMatches(symbol,retryOnError,waitingMinutesBeforeRetry)](#M-BarbezDotEu-AlphaVantage-Interfaces-IAlphaVantageDataProvider-GetBaseCompanyDataPartialMatches-System-String,System-Boolean,System-Double- 'BarbezDotEu.AlphaVantage.Interfaces.IAlphaVantageDataProvider.GetBaseCompanyDataPartialMatches(System.String,System.Boolean,System.Double)')
- [QueryResponse](#T-BarbezDotEu-AlphaVantage-DTO-QueryResponse 'BarbezDotEu.AlphaVantage.DTO.QueryResponse')
  - [Matches](#P-BarbezDotEu-AlphaVantage-DTO-QueryResponse-Matches 'BarbezDotEu.AlphaVantage.DTO.QueryResponse.Matches')
  - [GetFirstOfDefaultAbsoluteMatch()](#M-BarbezDotEu-AlphaVantage-DTO-QueryResponse-GetFirstOfDefaultAbsoluteMatch 'BarbezDotEu.AlphaVantage.DTO.QueryResponse.GetFirstOfDefaultAbsoluteMatch')

<a name='T-BarbezDotEu-AlphaVantage-AlphaVantageConfiguration'></a>
## AlphaVantageConfiguration `type`

##### Namespace

BarbezDotEu.AlphaVantage

##### Summary

Implements and houses configuration parameters to correctly connect to and communicate with Alpha Vantage's services.

<a name='M-BarbezDotEu-AlphaVantage-AlphaVantageConfiguration-#ctor-System-String,System-String-'></a>
### #ctor(maxCallsPerDay,symbolSearchUrl) `constructor`

##### Summary

Constructs a new [AlphaVantageConfiguration](#T-BarbezDotEu-AlphaVantage-AlphaVantageConfiguration 'BarbezDotEu.AlphaVantage.AlphaVantageConfiguration') using given parameters.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| maxCallsPerDay | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The max. number of calls per day before API calls become rate limited by Alpha Vantage. |
| symbolSearchUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The fully-qualified URL to use to search for symbols, including the API key. However, omit the actual search symbol. |

<a name='M-BarbezDotEu-AlphaVantage-AlphaVantageConfiguration-#ctor-System-Int64,System-String-'></a>
### #ctor(maxCallsPerDay,symbolSearchUrl) `constructor`

##### Summary

Constructs a new [AlphaVantageConfiguration](#T-BarbezDotEu-AlphaVantage-AlphaVantageConfiguration 'BarbezDotEu.AlphaVantage.AlphaVantageConfiguration') using given parameters.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| maxCallsPerDay | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The max. number of calls per day before API calls become rate limited by Alpha Vantage. |
| symbolSearchUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The fully-qualified URL to use to search for symbols, including the API key. However, omit the actual search symbol. |

<a name='M-BarbezDotEu-AlphaVantage-AlphaVantageConfiguration-#ctor-System-String-'></a>
### #ctor(apiKey) `constructor`

##### Summary

Constructs a new [AlphaVantageConfiguration](#T-BarbezDotEu-AlphaVantage-AlphaVantageConfiguration 'BarbezDotEu.AlphaVantage.AlphaVantageConfiguration') using all-default settings.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| apiKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The API key (to be requested via Alpha Vantage's website prior to using this library). |

<a name='P-BarbezDotEu-AlphaVantage-AlphaVantageConfiguration-MaxCallsPerDay'></a>
### MaxCallsPerDay `property`

##### Summary

Gets the maximum number of calls allowed per day.

<a name='P-BarbezDotEu-AlphaVantage-AlphaVantageConfiguration-SymbolSearchUrl'></a>
### SymbolSearchUrl `property`

##### Summary

Gets the fully-qualified URL to use to search for symbols, including the API key. However, omits the actual search symbol.

<a name='T-BarbezDotEu-AlphaVantage-AlphaVantage-AlphaVantageDataProvider'></a>
## AlphaVantageDataProvider `type`

##### Namespace

BarbezDotEu.AlphaVantage.AlphaVantage

##### Summary

Implements a data provider that connects to and can call Alpha Vantage APIs.

<a name='M-BarbezDotEu-AlphaVantage-AlphaVantage-AlphaVantageDataProvider-#ctor-Microsoft-Extensions-Logging-ILogger,System-Net-Http-IHttpClientFactory-'></a>
### #ctor(logger,httpClientFactory) `constructor`

##### Summary

Constructs a [AlphaVantageDataProvider](#T-BarbezDotEu-AlphaVantage-AlphaVantage-AlphaVantageDataProvider 'BarbezDotEu.AlphaVantage.AlphaVantage.AlphaVantageDataProvider').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logger | [Microsoft.Extensions.Logging.ILogger](#T-Microsoft-Extensions-Logging-ILogger 'Microsoft.Extensions.Logging.ILogger') | A [ILogger](#T-Microsoft-Extensions-Logging-ILogger 'Microsoft.Extensions.Logging.ILogger') to use for logging. |
| httpClientFactory | [System.Net.Http.IHttpClientFactory](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.IHttpClientFactory 'System.Net.Http.IHttpClientFactory') | The [IHttpClientFactory](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.IHttpClientFactory 'System.Net.Http.IHttpClientFactory') to use. |

<a name='P-BarbezDotEu-AlphaVantage-AlphaVantage-AlphaVantageDataProvider-Configuration'></a>
### Configuration `property`

##### Summary

Gets the [AlphaVantageConfiguration](#T-BarbezDotEu-AlphaVantage-AlphaVantageConfiguration 'BarbezDotEu.AlphaVantage.AlphaVantageConfiguration') this [AlphaVantageDataProvider](#T-BarbezDotEu-AlphaVantage-AlphaVantage-AlphaVantageDataProvider 'BarbezDotEu.AlphaVantage.AlphaVantage.AlphaVantageDataProvider') uses to communicate to the APIs.

<a name='M-BarbezDotEu-AlphaVantage-AlphaVantage-AlphaVantageDataProvider-Configure-BarbezDotEu-AlphaVantage-AlphaVantageConfiguration-'></a>
### Configure() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-BarbezDotEu-AlphaVantage-AlphaVantage-AlphaVantageDataProvider-GetBaseCompanyDataFullyMatching-System-String,System-Boolean,System-Double-'></a>
### GetBaseCompanyDataFullyMatching() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-BarbezDotEu-AlphaVantage-AlphaVantage-AlphaVantageDataProvider-GetBaseCompanyDataPartialMatches-System-String,System-Boolean,System-Double-'></a>
### GetBaseCompanyDataPartialMatches() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataFullMatch'></a>
## BaseCompanyDataFullMatch `type`

##### Namespace

BarbezDotEu.AlphaVantage.DTO

##### Summary

Implements a base company data DTO that EXACTLY matches a query.

<a name='M-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataFullMatch-#ctor-System-String,System-String,System-String,System-String,System-String,System-String,System-String,System-String-'></a>
### #ctor(currency,marketClose,marketOpen,name,region,symbol,timeZone,type) `constructor`

##### Summary

Constructs a new [BaseCompanyDataFullMatch](#T-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataFullMatch 'BarbezDotEu.AlphaVantage.DTO.BaseCompanyDataFullMatch').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| currency | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The currency. |
| marketClose | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | When the market closes. |
| marketOpen | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | When the market opens. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the company. |
| region | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The region the company is located in. |
| symbol | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The company's ticker symbol. |
| timeZone | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The timezone. |
| type | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The type. |

<a name='P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataFullMatch-Currency'></a>
### Currency `property`

##### Summary

Gets or sets the currency.

<a name='P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataFullMatch-MarketClose'></a>
### MarketClose `property`

##### Summary

Gets or sets when the market closes.

<a name='P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataFullMatch-MarketOpen'></a>
### MarketOpen `property`

##### Summary

Gets or sets when the market opens.

<a name='P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataFullMatch-Name'></a>
### Name `property`

##### Summary

Gets or sets the company name.

<a name='P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataFullMatch-Region'></a>
### Region `property`

##### Summary

Gets or sets the region.

<a name='P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataFullMatch-Symbol'></a>
### Symbol `property`

##### Summary

Gets or sets the company's symbol.

<a name='P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataFullMatch-Timezone'></a>
### Timezone `property`

##### Summary

Gets or sets the timezone.

<a name='P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataFullMatch-Type'></a>
### Type `property`

##### Summary

Gets or sets the type.

<a name='T-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataPartialMatch'></a>
## BaseCompanyDataPartialMatch `type`

##### Namespace

BarbezDotEu.AlphaVantage.DTO

##### Summary

Implements a base company data DTO that matches a query either completely, or to a certain extent only.

<a name='P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataPartialMatch-Currency'></a>
### Currency `property`

##### Summary

Gets or sets the currency.

<a name='P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataPartialMatch-MarketClose'></a>
### MarketClose `property`

##### Summary

Gets or sets the market close time.

<a name='P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataPartialMatch-MarketOpen'></a>
### MarketOpen `property`

##### Summary

Gets or sets the market open time.

<a name='P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataPartialMatch-MatchScore'></a>
### MatchScore `property`

##### Summary

Gets or sets a percentage in which the result is a match in the context of a query.

<a name='P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataPartialMatch-Name'></a>
### Name `property`

##### Summary

Gets or sets the company name.

<a name='P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataPartialMatch-Region'></a>
### Region `property`

##### Summary

Gets or sets the region.

<a name='P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataPartialMatch-Symbol'></a>
### Symbol `property`

##### Summary

Gets or sets the symbol.

<a name='P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataPartialMatch-TimeZone'></a>
### TimeZone `property`

##### Summary

Gets or sets the time zone.

<a name='P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataPartialMatch-Type'></a>
### Type `property`

##### Summary

Gets or sets the type.

<a name='M-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataPartialMatch-AsFullMatch'></a>
### AsFullMatch() `method`

##### Summary

Assumes an therefore returns this [BaseCompanyDataPartialMatch](#T-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataPartialMatch 'BarbezDotEu.AlphaVantage.DTO.BaseCompanyDataPartialMatch') is a [BaseCompanyDataFullMatch](#T-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataFullMatch 'BarbezDotEu.AlphaVantage.DTO.BaseCompanyDataFullMatch').

##### Returns

The [BaseCompanyDataFullMatch](#T-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataFullMatch 'BarbezDotEu.AlphaVantage.DTO.BaseCompanyDataFullMatch') representation of this [BaseCompanyDataPartialMatch](#T-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataPartialMatch 'BarbezDotEu.AlphaVantage.DTO.BaseCompanyDataPartialMatch').

##### Parameters

This method has no parameters.

<a name='M-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataPartialMatch-GetMatchScore'></a>
### GetMatchScore() `method`

##### Summary

Gets the [MatchScore](#P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataPartialMatch-MatchScore 'BarbezDotEu.AlphaVantage.DTO.BaseCompanyDataPartialMatch.MatchScore') as a double.

##### Returns

The [MatchScore](#P-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataPartialMatch-MatchScore 'BarbezDotEu.AlphaVantage.DTO.BaseCompanyDataPartialMatch.MatchScore') as a double.

##### Parameters

This method has no parameters.

<a name='T-BarbezDotEu-AlphaVantage-Interfaces-IAlphaVantageDataProvider'></a>
## IAlphaVantageDataProvider `type`

##### Namespace

BarbezDotEu.AlphaVantage.Interfaces

##### Summary

Defines a blueprint for a data provider that connects to and can call Alpha Vantage APIs.

<a name='M-BarbezDotEu-AlphaVantage-Interfaces-IAlphaVantageDataProvider-Configure-BarbezDotEu-AlphaVantage-AlphaVantageConfiguration-'></a>
### Configure(alphaVantageConfiguration) `method`

##### Summary

Configures this [IAlphaVantageDataProvider](#T-BarbezDotEu-AlphaVantage-Interfaces-IAlphaVantageDataProvider 'BarbezDotEu.AlphaVantage.Interfaces.IAlphaVantageDataProvider') so that it can successfully communicate with the Alpha Vantage APIs.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| alphaVantageConfiguration | [BarbezDotEu.AlphaVantage.AlphaVantageConfiguration](#T-BarbezDotEu-AlphaVantage-AlphaVantageConfiguration 'BarbezDotEu.AlphaVantage.AlphaVantageConfiguration') | The [AlphaVantageConfiguration](#T-BarbezDotEu-AlphaVantage-AlphaVantageConfiguration 'BarbezDotEu.AlphaVantage.AlphaVantageConfiguration') to configure this [IAlphaVantageDataProvider](#T-BarbezDotEu-AlphaVantage-Interfaces-IAlphaVantageDataProvider 'BarbezDotEu.AlphaVantage.Interfaces.IAlphaVantageDataProvider') with. |

##### Remarks

Configuration is required before any APIs can be called.

<a name='M-BarbezDotEu-AlphaVantage-Interfaces-IAlphaVantageDataProvider-GetBaseCompanyDataFullyMatching-System-String,System-Boolean,System-Double-'></a>
### GetBaseCompanyDataFullyMatching(symbol,retryOnError,waitingMinutesBeforeRetry) `method`

##### Summary

Gets base company data for a given symbol that EXACTLY matches a query.
Returns, if exists, a [BaseCompanyDataFullMatch](#T-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataFullMatch 'BarbezDotEu.AlphaVantage.DTO.BaseCompanyDataFullMatch') DTO containing the first result that is a 100% match. Returns NULL when no 100% match exists, or when no results were returned from the API.

##### Returns

The requested [BaseCompanyDataFullMatch](#T-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataFullMatch 'BarbezDotEu.AlphaVantage.DTO.BaseCompanyDataFullMatch').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| symbol | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The symbol to return data for. |
| retryOnError | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Set to TRUE to retry the request, in case the initial request should prove unsuccessful. |
| waitingMinutesBeforeRetry | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | The number of minutes to wait before automatically retrying re-sending the request, if the intention is to retry again upon error. |

<a name='M-BarbezDotEu-AlphaVantage-Interfaces-IAlphaVantageDataProvider-GetBaseCompanyDataPartialMatches-System-String,System-Boolean,System-Double-'></a>
### GetBaseCompanyDataPartialMatches(symbol,retryOnError,waitingMinutesBeforeRetry) `method`

##### Summary

Gets base company data DTO that matches a query either completely, or to a certain extent only.

##### Returns

The requested [BaseCompanyDataFullMatch](#T-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataFullMatch 'BarbezDotEu.AlphaVantage.DTO.BaseCompanyDataFullMatch')es.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| symbol | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The symbol to return data for. |
| retryOnError | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Set to TRUE to retry the request, in case the initial request should prove unsuccessful. |
| waitingMinutesBeforeRetry | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | The number of minutes to wait before automatically retrying re-sending the request, if the intention is to retry again upon error. |

<a name='T-BarbezDotEu-AlphaVantage-DTO-QueryResponse'></a>
## QueryResponse `type`

##### Namespace

BarbezDotEu.AlphaVantage.DTO

##### Summary

Implements the query response contract as defined by Alpha Vantage.

<a name='P-BarbezDotEu-AlphaVantage-DTO-QueryResponse-Matches'></a>
### Matches `property`

##### Summary

Gets or sets the set of [BaseCompanyDataPartialMatch](#T-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataPartialMatch 'BarbezDotEu.AlphaVantage.DTO.BaseCompanyDataPartialMatch')es returned by the API.

<a name='M-BarbezDotEu-AlphaVantage-DTO-QueryResponse-GetFirstOfDefaultAbsoluteMatch'></a>
### GetFirstOfDefaultAbsoluteMatch() `method`

##### Summary

Returns, if exists, a [BaseCompanyDataFullMatch](#T-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataFullMatch 'BarbezDotEu.AlphaVantage.DTO.BaseCompanyDataFullMatch') DTO containing the first result that is a 100% match. Returns NULL when no 100% match exists, or no results are returned.

##### Returns

The [BaseCompanyDataFullMatch](#T-BarbezDotEu-AlphaVantage-DTO-BaseCompanyDataFullMatch 'BarbezDotEu.AlphaVantage.DTO.BaseCompanyDataFullMatch') equivalent of this [QueryResponse](#T-BarbezDotEu-AlphaVantage-DTO-QueryResponse 'BarbezDotEu.AlphaVantage.DTO.QueryResponse').

##### Parameters

This method has no parameters.
