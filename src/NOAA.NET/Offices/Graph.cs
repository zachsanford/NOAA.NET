// <copyright file="Graph.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;
using System.Text.Json.Serialization;

namespace NOAA.NET.Offices;

/// <summary>
/// A representation of an OfficeHeadline
/// object.
/// </summary>
public class Graph
{
    /// <summary>
    /// Gets or sets the @Id URL property.
    /// </summary>
    [JsonPropertyName("@id")]
    public string? MainId { get; set; }

    /// <summary>
    /// Gets or sets the Id property.
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the Office
    /// URL property.
    /// </summary>
    public string? Office { get; set; }

    /// <summary>
    /// Gets or sets the Important flag
    /// property.
    /// </summary>
    public bool? Important { get; set; }

    /// <summary>
    /// Gets or sets the Issuance Time
    /// property.
    /// </summary>
    public DateTime? IssuanceTime { get; set; }

    /// <summary>
    /// Gets or sets the Link URL property.
    /// </summary>
    public string? Link { get; set; }

    /// <summary>
    /// Gets or sets the Name property.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the Title property.
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// Gets or sets the Summary property.
    /// </summary>
    public string? Summary { get; set; }

    /// <summary>
    /// Gets or sets the Content property.
    /// </summary>
    public string? Content { get; set; }
}
