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
    /// Gets or sets the Status Property.
    /// </summary>
    public Status? Status { get; set; }

    /// <summary>
    /// Gets or sets the MessageType Property.
    /// </summary>
    public MessageType? MessageType { get; set; }

    /// <summary>
    /// Gets or sets the Area Property.
    /// </summary>
    public string? Area { get; set; }

    /// <summary>
    /// Gets or sets the Region Property.
    /// </summary>
    public Region? Region { get; set; }

    /// <summary>
    /// Gets or sets the Urgency Property.
    /// </summary>
    public Urgency? Urgency { get; set; }

    /// <summary>
    /// Gets or sets the Severity Property.
    /// </summary>
    public Severity? Severity { get; set; }

    /// <summary>
    /// Gets or sets the Certainty Property.
    /// </summary>
    public Certainty? Certainty { get; set; }

    /// <summary>
    /// Gets or sets the Zone Property.
    /// </summary>
    public string? Zone { get; set; }

    /// <summary>
    /// Gets or sets the Limit Property.
    /// </summary>
    public int? Limit { get; set; } = 50;
}
