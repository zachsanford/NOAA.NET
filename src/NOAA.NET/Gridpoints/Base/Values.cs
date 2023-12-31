﻿// <copyright file="Values.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Gridpoints.Base;

/// <summary>
/// A representation of a Value object
/// for extra properties.
/// </summary>
public class Values
{
    /// <summary>
    /// Gets or sets the Valid Time property.
    /// </summary>
    public string? ValidTime { get; set; }

    /// <summary>
    /// Gets or sets the Value property.
    /// </summary>
    public float? Value { get; set; }
}
