// <copyright file="ObservationsBuilder.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;

namespace NOAA.NET.Stations.Observations;

/// <summary>
/// Builder class for the Stations/Observations Endpoint.
/// </summary>
public class ObservationsBuilder
{
    /// <summary>
    /// Gets or sets the Start Time property.
    /// </summary>
    public DateTime? Start { get; set; }

    /// <summary>
    /// Gets or sets the End Time property.
    /// </summary>
    public DateTime? End { get; set; }

    /// <summary>
    /// Gets or sets the Limit property. Defaults to
    /// 1 if left unset. Max value is 500.
    /// </summary>
    public ushort Limit { get; set; } = 1;

    /// <summary>
    /// Gets or sets the Observation Station ID property.
    /// </summary>
    public required string StationId { get; set; }
}
