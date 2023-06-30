// <copyright file="Properties.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;

namespace NOAA.NET.Aviation.Sigmets;

/// <summary>
/// A representation of a Sigmet
/// Object.
/// </summary>
public class Properties
{
    /// <summary>
    /// Gets or sets the ID Property.
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the Issue Time Property.
    /// </summary>
    public DateTime? IssueTime { get; set; }

    /// <summary>
    /// Gets or sets the Fir Property.
    /// </summary>
    public string? Fir { get; set; }

    /// <summary>
    /// Gets or sets the ATSU Property.
    /// </summary>
    public string? Atsu { get; set; }

    /// <summary>
    /// Gets or sets the Sequence Number Property.
    /// </summary>
    public string? Sequence { get; set; }

    /// <summary>
    /// Gets or sets the Phenomenon Property.
    /// </summary>
    public string? Phenomenon { get; set; }

    /// <summary>
    /// Gets or sets the Start Property.
    /// </summary>
    public DateTime? Start { get; set; }

    /// <summary>
    /// Gets or sets the End Property.
    /// </summary>
    public DateTime? End { get; set; }
}
