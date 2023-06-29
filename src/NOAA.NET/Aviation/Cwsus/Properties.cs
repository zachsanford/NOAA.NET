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
    /// Gets or sets the ID Property.
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the Issue Time Property.
    /// </summary>
    public DateTime? IssueTime { get; set; }

    /// <summary>
    /// Gets or sets the three-letter identifier for
    /// a Center Weather Service Unit (CWSU) Property.
    /// </summary>
    public string? Cwsu { get; set; }

    /// <summary>
    /// Gets or sets the Sequence Number Property.
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Gets or sets the Start Property.
    /// </summary>
    public DateTime? Start { get; set; }

    /// <summary>
    /// Gets or sets the End Property.
    /// </summary>
    public DateTime? End { get; set; }

    /// <summary>
    /// Gets or sets the Observed Property.
    /// </summary>
    public string? ObservedProperty { get; set; }

    /// <summary>
    /// Gets or sets the Text Property.
    /// </summary>
    public string? Text { get; set; }
}
