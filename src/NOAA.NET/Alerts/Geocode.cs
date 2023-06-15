// <copyright file="Geocode.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Alerts;

/// <summary>
/// Lists of codes for NWS public zones and counties
/// affected by the alert.
/// </summary>
public class Geocode
{
    /// <summary>
    /// Gets or sets a list of SAME (Specific Area Message
    /// Encoding) codes for affected counties.
    /// </summary>
    public string[]? SAME { get; set; }

    /// <summary>
    /// Gets or sets a list of NWS public zone or
    /// county identifiers. e.g. NWSZoneID.
    /// </summary>
    public string[]? UGC { get; set; }
}
