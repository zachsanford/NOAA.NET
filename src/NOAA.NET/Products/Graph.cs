// <copyright file="Graph.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;
using System.Text.Json.Serialization;

namespace NOAA.NET.Products;

/// <summary>
/// A representation of a TextProduct object.
/// </summary>
public class Graph
{
    /// <summary>
    /// Gets or sets the @id URL property.
    /// </summary>
    [JsonPropertyName("@id")]
    public string? MainId { get; set; }

    /// <summary>
    /// Gets or sets the Id property.
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the WMO Collective Id
    /// property.
    /// </summary>
    public string? WmoCollectiveId { get; set; }

    /// <summary>
    /// Gets or sets the Issuing Office property.
    /// </summary>
    public string? IssuingOffice { get; set; }

    /// <summary>
    /// Gets or sets the Issuance Time property.
    /// </summary>
    public DateTime? IssuanceTime { get; set; }

    /// <summary>
    /// Gets or sets the Product Code property.
    /// </summary>
    public string? ProductCode { get; set; }

    /// <summary>
    /// Gets or sets the Product Name property.
    /// </summary>
    public string? ProductName { get; set; }
}
