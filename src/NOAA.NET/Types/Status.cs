// <copyright file="Status.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Extensions;

namespace NOAA.NET.Types;

/// <summary>
/// Status enum for the "status" input of the Alert Endpoint.
/// </summary>
public enum Status
{
    /// <summary>
    /// Actual type for the "status" value of the Alert Endpoint.
    /// </summary>
    [StringValue("actual")]
    Actual,

    /// <summary>
    /// Exercise type for the "status" value of the Alert Endpoint.
    /// </summary>
    [StringValue("exercise")]
    Exercise,

    /// <summary>
    /// System type for the "status" value of the Alert Endpoint.
    /// </summary>
    [StringValue("system")]
    System,

    /// <summary>
    /// Test type for the "status" value of the Alert Endpoint.
    /// </summary>
    [StringValue("test")]
    Test,

    /// <summary>
    /// Draft type for the "status" value of the Alert Endpoint.
    /// </summary>
    [StringValue("draft")]
    Draft
}
