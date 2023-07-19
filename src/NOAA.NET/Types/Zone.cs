// <copyright file="Zone.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Extensions;

namespace NOAA.NET.Types;

/// <summary>
/// Zone Type enum for the "type" input of the Zones Endpoint.
/// </summary>
public enum Zone
{
    /// <summary>
    /// Coastal type for the "type" value of the Zones Endpoint.
    /// </summary>
    [StringValue("coastal")]
    Coastal,

    /// <summary>
    /// County type for the "type" value of the Zones Endpoint.
    /// </summary>
    [StringValue("county")]
    County,

    /// <summary>
    /// Fire type for the "type" value of the Zones Endpoint.
    /// </summary>
    [StringValue("fire")]
    Fire,

    /// <summary>
    /// Forecast type for the "type" value of the Zones Endpoint.
    /// </summary>
    [StringValue("forecast")]
    Forecast,

    /// <summary>
    /// Land type for the "type" value of the Zones Endpoint.
    /// </summary>
    [StringValue("land")]
    Land,

    /// <summary>
    /// Marine type for the "type" value of the Zones Endpoint.
    /// </summary>
    [StringValue("marine")]
    Marine,

    /// <summary>
    /// Offshore type for the "type" value of the Zones Endpoint.
    /// </summary>
    [StringValue("offshore")]
    Offshore,

    /// <summary>
    /// Public type for the "type" value of the Zones Endpoint.
    /// </summary>
    [StringValue("public")]
    Public
}