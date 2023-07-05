// <copyright file="Units.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Extensions;

namespace NOAA.NET.Gridpoints.Types;

/// <summary>
/// Units enum for the Gridpoints Forecast
/// Endpoint Units Parameter.
/// </summary>
public enum Units
{
    /// <summary>
    /// US type for the "Units" value of the Gridpoints Forecast
    /// Endpoint.
    /// </summary>
    [StringValue("us")]
    US,

    /// <summary>
    /// SI type for the "Units" value of the Gridpoints Forecast
    /// Endpoint.
    /// </summary>
    [StringValue("si")]
    SI
}
