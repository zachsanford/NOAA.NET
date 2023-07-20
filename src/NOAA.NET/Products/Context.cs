// <copyright file="Context.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System.Text.Json.Serialization;

namespace NOAA.NET.Products;

/// <summary>
/// A representation of a Context object.
/// </summary>
public class Context
{
    /// <summary>
    /// Gets or sets the Version property.
    /// </summary>
    [JsonPropertyName("@version")]
    public string? Version { get; set; }

    /// <summary>
    /// Gets or sets the Vocab property.
    /// </summary>
    [JsonPropertyName("@vocab")]
    public string? Vocab { get; set; }
}
