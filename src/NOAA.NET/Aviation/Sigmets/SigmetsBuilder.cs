// <copyright file="SigmetsBuilder.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;

namespace NOAA.NET.Aviation.Sigmets;

/// <summary>
/// Builder Class for the Aviation/SIGMETs Endpoint.
/// </summary>
public sealed class SigmetsBuilder
{
    /// <summary>
    /// Gets or sets the Start Time property.
    /// </summary>
    public DateTime? Start { get; set; }

    /// <summary>
    /// Gets or sets the End Time property.
    /// </summary>
    public DateTime? End { get; set; }

    /// <summary>
    /// Gets or sets the Date property.
    /// </summary>
    public DateTime? Date { get; set; }

    /// <summary>
    /// Gets or sets the ATSU Identifier property. The <see cref="string"/>
    /// needs to match the following <see cref="System.Text.RegularExpressions.Regex"/>
    /// pattern: <c>^[A-Z]{3,4}$</c>.
    /// </summary>
    public string? Atsu { get; set; }

    /// <summary>
    /// Gets or sets the SIGMET Sequence Number property.
    /// </summary>
    public string? Sequence { get; set; }
}
