// <copyright file="Certainty.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Extensions;

namespace NOAA.NET.Alerts.Types;

/// <summary>
/// Certainty enum for the "certainty" input of the Alert Endpoint.
/// </summary>
public enum Certainty
{
    /// <summary>
    /// Observed type for the "certainty" value of the Alert Endpoint.
    /// </summary>
    [StringValue("Observed")]
    Observed,

    /// <summary>
    /// Likely type for the "certainty" value of the Alert Endpoint.
    /// </summary>
    [StringValue("Likely")]
    Likely,

    /// <summary>
    /// Possible type for the "certainty" value of the Alert Endpoint.
    /// </summary>
    [StringValue("Possible")]
    Possible,

    /// <summary>
    /// Unlikely type for the "certainty" value of the Alert Endpoint.
    /// </summary>
    [StringValue("Unlikely")]
    Unlikely,

    /// <summary>
    /// Unknown type for the "certainty" value of the Alert Endpoint.
    /// </summary>
    [StringValue("Unknown")]
    Unknown
}
