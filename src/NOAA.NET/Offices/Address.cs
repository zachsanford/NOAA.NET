// <copyright file="Address.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Offices;

/// <summary>
/// A representation of an Address object.
/// </summary>
public class Address
{
    /// <summary>
    /// Gets or sets the Type property.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the Street Address property.
    /// </summary>
    public string? StreetAddress { get; set; }

    /// <summary>
    /// Gets or sets the Address Locality property.
    /// </summary>
    public string? AddressLocality { get; set; }

    /// <summary>
    /// Gets or sets the Address Region property.
    /// </summary>
    public string? AddressRegion { get; set; }

    /// <summary>
    /// Gets or sets the Postal Code property.
    /// </summary>
    public string? PostalCode { get; set; }
}
