﻿// <copyright file="CwsusBuilder.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Types;

namespace NOAA.NET.Aviation.Cwsus;

/// <summary>
/// Builder Class for the Aviation/CWSUS Endpoint.
/// </summary>
public sealed class CwsusBuilder
{
    /// <summary>
    /// Gets or sets the NWS CWSU ID property.
    /// </summary>
    public CwsuId CwsuId { get; set; }
}
