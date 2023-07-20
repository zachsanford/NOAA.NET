// <copyright file="ProductsResponse.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System.Text.Json.Serialization;

namespace NOAA.NET.Products;

/// <summary>
/// A representation of a Products endpoint response.
/// </summary>
public class ProductsResponse
{
    /// <summary>
    /// Gets or sets the
    /// <see cref="NOAA.NET.Products.Context"/>
    /// property.
    /// </summary>
    [JsonPropertyName("@context")]
    public Context? Context { get; set; }

    /// <summary>
    /// Gets or sets the
    /// <see cref="NOAA.NET.Products.Graph"/>
    /// collection property.
    /// </summary>
    [JsonPropertyName("@graph")]
    public Graph[]? Graph { get; set; }
}
