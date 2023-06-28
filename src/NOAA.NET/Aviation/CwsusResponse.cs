// <copyright file="CwsusResponse.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Aviation;

/// <summary>
/// A representation of an Aviation/CWSUS Endpoint
/// response.
/// </summary>
public class CwsusResponse
{
    /// <summary>
    /// Gets or sets the <see cref="Context"/> Property.
    /// </summary>
    public Context? Context { get; set; }

    /// <summary>
    /// Gets or sets the Type Property.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets a collection of <see cref="Feature"/> objects.
    /// </summary>
    public Feature[]? Features { get; set; }
}
