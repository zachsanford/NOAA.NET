// <copyright file="Urgency.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Extensions;

namespace NOAA.NET.Alerts.Types;

/// <summary>
/// Urgency enum for the "urgency" input of the Alert Endpoint.
/// </summary>
public enum Urgency
{
    /// <summary>
    /// Immediate type for the "urgency" value of the Alert Endpoint.
    /// </summary>
    [StringValue("Immediate")]
    Immediate,

    /// <summary>
    /// Expected type for the "urgency" value of the Alert Endpoint.
    /// </summary>
    [StringValue("Expected")]
    Expected,

    /// <summary>
    /// Future type for the "urgency" value of the Alert Endpoint.
    /// </summary>
    [StringValue("Future")]
    Future,

    /// <summary>
    /// Past type for the "urgency" value of the Alert Endpoint.
    /// </summary>
    [StringValue("Past")]
    Past,

    /// <summary>
    /// Unknown type for the "urgency" value of the Alert Endpoint.
    /// </summary>
    [StringValue("Unknown")]
    Unknown
}
