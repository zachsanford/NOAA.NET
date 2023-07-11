// <copyright file="RegionType.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Extensions;

namespace NOAA.NET.Types;

/// <summary>
/// RegionType enum for the "region_type" input of the Alert Endpoint.
/// </summary>
public enum RegionType
{
    /// <summary>
    /// Land type for the "region_type" value of the Alert Endpoint.
    /// </summary>
    [StringValue("land")]
    Land,

    /// <summary>
    /// Marine type for the "region_type" value of the Alert Endpoint.
    /// </summary>
    [StringValue("marine")]
    Marine
}
