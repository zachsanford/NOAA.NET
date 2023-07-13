// <copyright file="CloudLayer.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Stations.Observations;

/// <summary>
/// A representation of a Cloud Layer object.
/// </summary>
public class CloudLayer
{
    /// <summary>
    /// Gets or sets the
    /// <see cref="NOAA.NET.Stations.Observations.Base"/> property.
    /// </summary>
    public Base? Base { get; set; }

    /// <summary>
    /// Gets or sets the Metar Sky Coverage Amount property.
    /// </summary>
    public string? Amount { get; set; }
}
