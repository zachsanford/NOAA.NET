// <copyright file="MessageType.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Extensions;

namespace NOAA.NET.Alerts.Types;

/// <summary>
/// MessageType enum for the "message_type" input of the Alert Endpoint.
/// </summary>
public enum MessageType
{
    /// <summary>
    /// Alert type for the "message_type" value of the Alert Endpoint.
    /// </summary>
    [StringValue("alert")]
    Alert,

    /// <summary>
    /// Update type for the "message_type" value of the Alert Endpoint.
    /// </summary>
    [StringValue("update")]
    Update,

    /// <summary>
    /// Cancel type for the "message_type" value of the Alert Endpoint.
    /// </summary>
    [StringValue("cancel")]
    Cancel
}
