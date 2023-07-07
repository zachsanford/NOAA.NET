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
    /// Gets or sets the ID property.
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the Issue Time property.
    /// </summary>
    public DateTime? IssueTime { get; set; }

    /// <summary>
    /// Gets or sets the Fir property.
    /// </summary>
    public string? Fir { get; set; }

    /// <summary>
    /// Gets or sets the ATSU property.
    /// </summary>
    public string? Atsu { get; set; }

    /// <summary>
    /// Gets or sets the Sequence Number property.
    /// </summary>
    public string? Sequence { get; set; }

    /// <summary>
    /// Gets or sets the Phenomenon property.
    /// </summary>
    public string? Phenomenon { get; set; }

    /// <summary>
    /// Gets or sets the Start property.
    /// </summary>
    public DateTime? Start { get; set; }

    /// <summary>
    /// Gets or sets the End property.
    /// </summary>
    public DateTime? End { get; set; }
}
