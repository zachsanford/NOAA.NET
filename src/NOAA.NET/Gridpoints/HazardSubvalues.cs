// <copyright file="HazardSubvalues.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System.Text.Json.Serialization;

namespace NOAA.NET.Gridpoints;

/// <summary>
/// A representation of a Hazard Subvalues
/// object.
/// </summary>
public class HazardSubvalues
{
    /// <summary>
    /// Gets or sets the Phenomenon Property.
    /// </summary>
    public string? Phenomenon { get; set; }

    /// <summary>
    /// Gets or sets the Significance Property.
    /// </summary>
    public string? Significance { get; set; }

    /// <summary>
    /// Gets or sets the EventNumber property.
    /// </summary>
    [JsonPropertyName("event_number")]
    public int? EventNumber { get; set; }
}
