// <copyright file="Parameters.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;

namespace NOAA.NET.Alerts;

/// <summary>
/// Rerpresents the system-specific additional parameters associated
/// with the alert message. The keys in this object correspond to
/// parameter definitions in the NWS CAP specification.
/// </summary>
public class Parameters
{
    /// <summary>
    /// Gets or sets the AWIPSidentifier for the parameter.
    /// </summary>
    public string[]? AWIPSidentifier { get; set; }

    /// <summary>
    /// Gets or sets the WMOidentifier for the parameter.
    /// </summary>
    public string[]? WMOidentifier { get; set; }

    /// <summary>
    /// Gets or sets the EventMotionDescription for the parameter.
    /// </summary>
    public string[]? EventMotionDescription { get; set; }

    /// <summary>
    /// Gets or sets the WindThreat for the parameter.
    /// </summary>
    public string[]? WindThreat { get; set; }

    /// <summary>
    /// Gets or sets the MaxWindGust for the parameter.
    /// </summary>
    public string[]? MaxWindGust { get; set; }

    /// <summary>
    /// Gets or sets the HailThreat for the parameter.
    /// </summary>
    public string[]? HailThreat { get; set; }

    /// <summary>
    /// Gets or sets the MaxHailSize for the parameter.
    /// </summary>
    public string[]? MaxHailSize { get; set; }

    /// <summary>
    /// Gets or sets the BLOCKCHANNEL for the parameter.
    /// </summary>
    public string[]? BLOCKCHANNEL { get; set; }

    /// <summary>
    /// Gets or sets the EASORG for the parameter.
    /// </summary>
    public string[]? EASORG { get; set; }

    /// <summary>
    /// Gets or sets the VTEC for the parameter.
    /// </summary>
    public string[]? VTEC { get; set; }

    /// <summary>
    /// Gets or sets the EventEndingTime for the parameter.
    /// </summary>
    public DateTime[]? EventEndingTime { get; set; }

    /// <summary>
    /// Gets or sets the NWSheadline for the parameter.
    /// </summary>
    public string[]? NWSheadline { get; set; }
}
