// <copyright file="Distance.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Points;

/// <summary>
/// A representation of a Distance object.
/// </summary>
public class Distance
{
    /// <summary>
    /// Gets or sets a string denoting a unit of
    /// measure.
    /// </summary>
    public string? UnitCode { get; set; }

    /// <summary>
    /// Gets or sets the measured value.
    /// </summary>
    public float? Value { get; set; }

    /// <summary>
    /// Gets or sets the Max Value property.
    /// </summary>
    public float? MaxValue { get; set; }

    /// <summary>
    /// Gets or sets the Min Value property.
    /// </summary>
    public float? MinValue { get; set; }

    /// <summary>
    /// Gets or sets the Quality Control property. For
    /// values in observation records, the quality control
    /// flag from the MADIS system. The definitions of
    /// these flags can be found at
    /// <see href="https://madis.ncep.noaa.gov/madis_sfc_qc_notes.shtml"/>.
    /// </summary>
    public string? QualityControl { get; set; }
}
