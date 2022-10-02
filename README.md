# Brapi SDK

## About

This is a wrapper for a API available that contains data from Brazilian Financial Markets.
Check it out at <https://brapi.dev/>

## How to Use

Just download the nuget package using nuget
dotnet add package BrapiSDK --version 1.0.0

## Examples

Get information from a brazilian stock.

```csharp
using BrapiSDK;
BrapiClient client = new();
DTO.DetailedTickerResultMessage result = await client.GetTickerQuote("PETR4", "1mo", "1d", true);
```

## Credits

Vinícius Schwinden Berkenbrock - Write the SDK

<https://brapi.dev/> - Make the API Available
