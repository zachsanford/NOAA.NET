// <copyright file="SigmetsResponse.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Aviation.Sigmets;

/// <summary>
/// A representation of an Aviation/Sigmets Endpoint
/// response.
/// </summary>
public class SigmetsResponse
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
