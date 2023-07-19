// <copyright file="Properties.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;

namespace NOAA.NET.Aviation.Cwsus;

/// <summary>
/// A representation of a CenterWeatherAdvisory
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
    /// Gets or sets the three-letter identifier for
    /// a Center Weather Service Unit (CWSU) property.
    /// </summary>
    public string? Cwsu { get; set; }

    /// <summary>
    /// Gets or sets the Sequence Number property.
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Gets or sets the Start property.
    /// </summary>
    public DateTime? Start { get; set; }

    /// <summary>
    /// Gets or sets the End property.
    /// </summary>
    public DateTime? End { get; set; }

    /// <summary>
    /// Gets or sets the Observed property.
    /// </summary>
    public string? ObservedProperty { get; set; }

    /// <summary>
    /// Gets or sets the Text property.
    /// </summary>
    public string? Text { get; set; }
}
