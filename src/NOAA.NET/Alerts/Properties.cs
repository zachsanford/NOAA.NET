// <copyright file="Properties.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;

namespace NOAA.NET.Alerts;

/// <summary>
/// Represents a public alert message. All fields
/// correspond to the National Weather Service CAP v1.2
/// specification.
/// </summary>
public class Properties
{
    /// <summary>
    /// Gets or sets the unique id of the alert message.
    /// </summary>
    public string? id { get; set; }

    /// <summary>
    /// Gets or sets the type of the alert message.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the alert message. e.g. AlertID.
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the description of the area affected by
    /// the alert.
    /// </summary>
    public string? AreaDesc { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="Geocode"/> of the alert message.
    /// </summary>
    public Geocode? Geocode { get; set; }

    /// <summary>
    /// Gets or sets the array of API links for zones affected
    /// by the alert message. This is an API-specific extension
    /// field and is not part of the CAP specification.
    /// </summary>
    public string[]? AffectedZones { get; set; }

    /// <summary>
    /// Gets or sets an array of prior alerts that this alert
    /// updates or replaces.
    /// </summary>
    public object[]? References { get; set; }

    /// <summary>
    /// Gets or sets the time of the origination of the alert
    /// message.
    /// </summary>
    public DateTime? Sent { get; set; }

    /// <summary>
    /// Gets or sets the effective time of the information of
    /// the alert message.
    /// </summary>
    public DateTime? Effective { get; set; }

    /// <summary>
    /// Gets or sets the expected time of the beginning of the
    /// subject event of the alert message.
    /// </summary>
    public DateTime? Onset { get; set; }

    /// <summary>
    /// Gets or sets the expiry time of the information of the
    /// alert message.
    /// </summary>
    public DateTime? Expires { get; set; }

    /// <summary>
    /// Gets or sets the expected end time of the subject event
    /// of the alert message.
    /// </summary>
    public DateTime? Ends { get; set; }

    /// <summary>
    /// Gets or sets the status of the alert message. e.g. AlertStatus.
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// Gets or sets the type of message for the alert
    /// message. e.g. AlertMessageType.
    /// </summary>
    public string? MessageType { get; set; }

    /// <summary>
    /// Gets or sets the code denoting the category of the
    /// subject event of the alert message.
    /// </summary>
    public string? Category { get; set; }

    /// <summary>
    /// Gets or sets the severity of the alert message.
    /// e.g. AlertSeverity.
    /// </summary>
    public string? Severity { get; set; }

    /// <summary>
    /// Gets or sets the certainty of the alert message.
    /// e.g. AlertCertainty.
    /// </summary>
    public string? Certainty { get; set; }

    /// <summary>
    /// Gets or sets the urgency of the alert message.
    /// e.ge. AlertUrgency.
    /// </summary>
    public string? Urgency { get; set; }

    /// <summary>
    /// Gets or sets the text denoting the type of the
    /// subject event of the alert message.
    /// </summary>
    public string? Event { get; set; }

    /// <summary>
    /// Gets or sets the email address of the NWS
    /// webmaster.
    /// </summary>
    public string? Sender { get; set; }

    /// <summary>
    /// Gets or sets the text naming the originator
    /// of the alert message.
    /// </summary>
    public string? SenderName { get; set; }

    /// <summary>
    /// Gets or sets the text headline of the alert
    /// message.
    /// </summary>
    public string? Headline { get; set; }

    /// <summary>
    /// Gets or sets the text describing the subject
    /// event of the alert message.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Gets or sets the text describing the recommended
    /// action to be taken by recipients of the alert
    /// message.
    /// </summary>
    public string? Instruction { get; set; }

    /// <summary>
    /// Gets or sets the code denoting the type of
    /// action recommended for the target audience.
    /// This corresponds to the responseType in the CAP
    /// specification.
    /// </summary>
    public string? Response { get; set; }

    /// <summary>
    /// Gets or sets the parameters of the alert message.
    /// </summary>
    public Parameters? Parameters { get; set; }
}
