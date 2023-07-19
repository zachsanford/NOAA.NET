// <copyright file="Bearing.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Points;

/// <summary>
/// A representation of a Bearing object.
/// </summary>
public class Bearing
{
    /// <summary>
    /// Gets or sets a string denoting a unit of
    /// measure.
    /// </summary>
    public string? UnitCode { get; set; }

    /// <summary>
    /// Gets or sets the measured value.
    /// </summary>
    public int? Value { get; set; }

    /// <summary>
    /// Gets or sets the Max Value property.
    /// </summary>
    public int? MaxValue { get; set; }

    /// <summary>
    /// Gets or sets the Min Value property.
    /// </summary>
    public int? MinValue { get; set; }

    /// <summary>
    /// Gets or sets the Quality Control property. For
    /// values in observation records, the quality control
    /// flag from the MADIS system. The definitions of
    /// these flags can be found at
    /// <see href="https://madis.ncep.noaa.gov/madis_sfc_qc_notes.shtml"/>.
    /// </summary>
    public string? QualityControl { get; set; }
}
