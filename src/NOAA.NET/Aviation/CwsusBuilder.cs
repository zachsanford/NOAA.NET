// <copyright file="CwsusBuilder.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;
using System.ComponentModel.DataAnnotations;
using NOAA.NET.Aviation.Types;

namespace NOAA.NET.Aviation;

/// <summary>
/// Builder Class for the Aviation/CWSUS Endpoint.
/// </summary>
public class CwsusBuilder
{
    /// <summary>
    /// Gets or sets the NWS CWSU ID Property.
    /// </summary>
    public CwsuId CwsuId { get; set; }
}
