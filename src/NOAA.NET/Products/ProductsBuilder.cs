// <copyright file="ProductsBuilder.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Types;

namespace NOAA.NET.Products;

/// <summary>
/// Builder class for the Products Endpoint.
/// </summary>
public sealed class ProductsBuilder
{
    /// <summary>
    /// Gets or sets the
    /// <see cref="NOAA.NET.Types.WFO"/>
    /// Location property.
    /// </summary>
    public WFO? Location { get; set; }

    /// <summary>
    /// Gets or sets the
    /// <see cref="NOAA.NET.Types.ProductCode"/>
    /// Type property.
    /// </summary>
    public ProductCode? Type { get; set; }

    /// <summary>
    /// Gets or sets the limit or returned results. Defaults
    /// to 50 if left unset.
    /// </summary>
    public ushort? Limit { get; set; } = 50;
}
