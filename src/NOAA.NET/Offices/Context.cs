// <copyright file="Context.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Offices;

/// <summary>
/// A represetation of a JsonLdContext
/// object.
/// </summary>
public class Context
{
    /// <summary>
    /// Gets or sets the Version property.
    /// </summary>
    public string? Version { get; set; }

    /// <summary>
    /// Gets or sets the Vocab property.
    /// </summary>
    public string? Vocab { get; set; }
}
