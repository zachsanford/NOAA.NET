// <copyright file="ProductsClient.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Products;

namespace NOAA.NET.Services.Network;

/// <summary>
/// Http client for the Products endpoint of the API.
/// </summary>
internal sealed class ProductsClient : NOAAClient<ProductsResponse>
{
    /// <inheritdoc/>
    protected override string BaseURL { get; } = @"https://api.weather.gov/products";

    /// <inheritdoc/>
    protected override string EndpointType { get; } = "Products";
}
