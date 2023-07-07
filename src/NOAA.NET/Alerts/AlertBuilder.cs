// <copyright file="AlertBuilder.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Alerts.Types;

namespace NOAA.NET.Alerts;

/// <summary>
/// Builder class for the Alert Endpoint.
/// </summary>
public sealed class AlertBuilder
{
    /// <summary>
    /// Gets or sets the Status property.
    /// </summary>
    public Types.Status? Status { get; set; }

    /// <summary>
    /// Gets or sets the MessageType property.
    /// </summary>
    public MessageType? MessageType { get; set; }

    /// <summary>
    /// Gets or sets the Area property.
    /// </summary>
    public string? Area { get; set; }

    /// <summary>
    /// Gets or sets the Region property.
    /// </summary>
    public Region? Region { get; set; }

    /// <summary>
    /// Gets or sets the Urgency property.
    /// </summary>
    public Urgency? Urgency { get; set; }

    /// <summary>
    /// Gets or sets the Severity property.
    /// </summary>
    public Severity? Severity { get; set; }

    /// <summary>
    /// Gets or sets the Certainty property.
    /// </summary>
    public Certainty? Certainty { get; set; }

    /// <summary>
    /// Gets or sets the Zone property.
    /// </summary>
    public string? Zone { get; set; }

    /// <summary>
    /// Gets or sets the Limit property.
    /// </summary>
    public int? Limit { get; set; } = 50;
}
