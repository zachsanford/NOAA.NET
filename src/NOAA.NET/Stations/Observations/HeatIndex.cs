// <copyright file="HeatIndex.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Stations.Observations;

/// <summary>
/// A representation of a Heat Index object.
/// </summary>
public class HeatIndex
{
    /// <summary>
    /// Gets or sets a string denoting the unit
    /// of measure.
    /// </summary>
    public string? UnitCode { get; set; }

    /// <summary>
    /// Gets or sets the measured value.
    /// </summary>
    public float? Value { get; set; }

    /// <summary>
    /// Gets or sets the Quality Control value. For
    /// values in observation records, the quality
    /// control flag from the MADIS system. The
    /// definitions flags can be found at
    /// <see href="https://madis.ncep.noaa.gov/madis_sfc_qc_notes.shtml"/>.
    /// </summary>
    public string? QualityControl { get; set; }
}
