// <copyright file="Region.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Extensions;

namespace NOAA.NET.Alerts.Types;

/// <summary>
/// Region enum used for the "region" input on the Alert Endpoint.
/// It is the Marine Region Code.
/// </summary>
public enum Region
{
    /// <summary>
    /// Alaska Waters type for the "region" value of the Alert Endpoint.
    /// </summary>
    [StringValue("AL")]
    AL,

    /// <summary>
    /// Atlantic Ocean type for the "region" value of the Alert Endpoint.
    /// </summary>
    [StringValue("AT")]
    AT,

    /// <summary>
    /// Great Lakes type for the "region" value of the Alert Endpoint.
    /// </summary>
    [StringValue("GL")]
    GL,

    /// <summary>
    /// Gulf of Mexico type for the "region" value of the Alert Endpoint.
    /// </summary>
    [StringValue("GM")]
    GM,

    /// <summary>
    /// Eastern Pacific Ocean and the U.S. West Coast type for the "region" value of the Alert Endpoint.
    /// </summary>
    [StringValue("PA")]
    PA,

    /// <summary>
    /// Central and Western Pacific type for the "region" value of the Alert Endpoint.
    /// </summary>
    [StringValue("PI")]
    PI
}
