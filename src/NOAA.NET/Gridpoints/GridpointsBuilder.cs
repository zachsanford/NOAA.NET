// <copyright file="GridpointsBuilder.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Gridpoints.Types;

namespace NOAA.NET.Gridpoints;

/// <summary>
/// Builder class for the Gridpoints Endpoint.
/// </summary>
public sealed class GridpointsBuilder
{
    /// <summary>
    /// Gets or sets the <see cref="WFO"/> type, for the
    /// Weather Forecast Office Property.
    /// </summary>
    public required WFO Wfo { get; set; }

    /// <summary>
    /// Gets or sets the forecast grid X coordinate
    /// Property.
    /// </summary>
    public required byte XCoordinate { get; set; }

    /// <summary>
    /// Gets or sets the forecast grid Y coordinate
    /// Property.
    /// </summary>
    public required byte YCoordinate { get; set; }
}
