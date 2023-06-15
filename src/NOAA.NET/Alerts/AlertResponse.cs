// <copyright file="AlertResponse.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;

namespace NOAA.NET.Alerts;

/// <summary>
/// A representation of the Alert Endpoint
/// response.
/// </summary>
public class AlertResponse
{
    /// <summary>
    /// Gets or sets the context for the alert collection.
    /// </summary>
    public object[]? Context { get; set; }

    /// <summary>
    /// Gets or sets the type for the alert collection.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="Feature"/> array
    /// for the alert collection.
    /// </summary>
    public Feature[]? Features { get; set; }

    /// <summary>
    /// Gets or sets the title describing the alert
    /// collection.
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// Gets or sets the last time a change occurred
    /// to this collection.
    /// </summary>
    public DateTime? Updated { get; set; }

    /// <summary>
    /// Gets or sets the pagination info for this
    /// alert collection.
    /// </summary>
    public Pagination? Pagination { get; set; }
}