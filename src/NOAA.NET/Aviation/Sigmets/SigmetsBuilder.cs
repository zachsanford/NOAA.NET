// <copyright file="SigmetsBuilder.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;

namespace NOAA.NET.Aviation.Sigmets;

/// <summary>
/// Builder Class for the Aviation/SIGMETs Endpoint.
/// </summary>
public class SigmetsBuilder
{
    /// <summary>
    /// Gets or sets the Start Time Property.
    /// </summary>
    public DateTime? Start { get; set; }

    /// <summary>
    /// Gets or sets the End Time Property.
    /// </summary>
    public DateTime? End { get; set; }

    /// <summary>
    /// Gets or sets the Date Property.
    /// </summary>
    public DateTime? Date { get; set; }

    /// <summary>
    /// Gets or sets the ATSU Identifier Property.
    /// </summary>
    public string? Atsu { get; set; }

    /// <summary>
    /// Gets or sets the SIGMET Sequence Number Property.
    /// </summary>
    public string? Sequence { get; set; }
}
