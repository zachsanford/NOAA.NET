// <copyright file="AlertActiveCountResponse.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System.Collections.Generic;

namespace NOAA.NET.Alerts;

/// <summary>
/// A data structure showing the counts of
/// active alerts broken down by various
/// categories.
/// </summary>
public class AlertActiveCountResponse
{
    /// <summary>
    /// Gets or sets the total number of
    /// active alerts.
    /// </summary>
    public int? Total { get; set; }

    /// <summary>
    /// Gets or sets the total number of
    /// active alerts affecting land zones.
    /// </summary>
    public int? Land { get; set; }

    /// <summary>
    /// Gets or sets the total number of
    /// active alerts affecting marine
    /// zones.
    /// </summary>
    public int? Marine { get; set; }

    /// <summary>
    /// Gets or sets a collection of
    /// active alerts by region.
    /// </summary>
    public Dictionary<string, int>? Regions { get; set; }

    /// <summary>
    /// Gets or sets a collection of
    /// active alerts by area.
    /// </summary>
    public Dictionary<string, int>? Areas { get; set; }

    /// <summary>
    /// Gets or sets a collection of
    /// active alerts by zone.
    /// </summary>
    public Dictionary<string, int>? Zones { get; set; }
}
