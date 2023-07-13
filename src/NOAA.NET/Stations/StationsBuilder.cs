// <copyright file="StationsBuilder.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Types;

namespace NOAA.NET.Stations;

/// <summary>
/// Builder class for the Stations Endpoint.
/// </summary>
public sealed class StationsBuilder
{
    /// <summary>
    /// Gets or sets the Id of the Observation Station as
    /// a property.
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the state/marine area code property.
    /// </summary>
    public Areas? State { get; set; }

    /// <summary>
    /// Gets or sets the limit or returned results. Defaults
    /// to 500 if left unset. Max value is 500.
    /// </summary>
    public ushort Limit { get; set; } = 500;

    /// <summary>
    /// Gets or sets the pagination cursor for the next
    /// result set as a property.
    /// </summary>
    public string? Cursor { get; set; }
}
