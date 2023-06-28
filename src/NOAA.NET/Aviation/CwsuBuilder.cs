// <copyright file="CwsuBuilder.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;
using System.ComponentModel.DataAnnotations;
using NOAA.NET.Aviation.Types;

namespace NOAA.NET.Aviation;

/// <summary>
/// Builder Class for the Aviation/CWSUS Endpoint.
/// </summary>
public class CwsuBuilder
{
    /// <summary>
    /// Gets or sets the NWS CWSU ID Property.
    /// </summary>
    public CwsuId CwsuId { get; set; }

    /// <summary>
    /// Gets or sets the Date Property.
    /// </summary>
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
    public DateTime? Date { get; set; }

    /// <summary>
    /// Gets or sets the Sequence Number Property.
    /// </summary>
    public int? Sequence { get; set; }
}
