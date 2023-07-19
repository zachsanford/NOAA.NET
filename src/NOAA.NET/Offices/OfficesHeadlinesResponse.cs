// <copyright file="OfficesHeadlinesResponse.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System.Text.Json.Serialization;

namespace NOAA.NET.Offices;

/// <summary>
/// A representation of an OfficeHeadlineCollection
/// object.
/// </summary>
public class OfficesHeadlinesResponse
{
    /// <summary>
    /// Gets or sets the
    /// <see cref="NOAA.NET.Offices.Context"/>
    /// property.
    /// </summary>
    [JsonPropertyName("@context")]
    public Context? Context { get; set; }

    /// <summary>
    /// Gets or sets the
    /// <see cref="NOAA.NET.Offices.Graph"/>
    /// collection property.
    /// </summary>
    [JsonPropertyName("@graph")]
    public Graph[]? Graph { get; set; }
}
