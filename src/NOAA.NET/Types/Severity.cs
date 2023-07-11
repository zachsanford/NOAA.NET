// <copyright file="Severity.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Extensions;

namespace NOAA.NET.Types;

/// <summary>
/// Severity enum for the "severity" input of the Alert Endpoint.
/// </summary>
public enum Severity
{
    /// <summary>
    /// Extreme type for the "severity" value of the Alert Endpoint.
    /// </summary>
    [StringValue("Extreme")]
    Extreme,

    /// <summary>
    /// Severe type for the "severity" value of the Alert Endpoint.
    /// </summary>
    [StringValue("Severe")]
    Severe,

    /// <summary>
    /// Moderate type for the "severity" value of the Alert Endpoint.
    /// </summary>
    [StringValue("Moderate")]
    Moderate,

    /// <summary>
    /// Minor type for the "severity" value of the Alert Endpoint.
    /// </summary>
    [StringValue("Minor")]
    Minor,

    /// <summary>
    /// Unknown type for the "severity" value of the Alert Endpoint.
    /// </summary>
    [StringValue("Unknown")]
    Unknown
}
