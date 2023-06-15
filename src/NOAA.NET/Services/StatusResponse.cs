// <copyright file="StatusResponse.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Services;

/// <summary>
/// Class to receive the status response from the
/// Status API Endpoint.
/// </summary>
public class StatusResponse
{
    /// <summary>
    /// Gets or sets the Status field from the API Endpoint.
    /// </summary>
    public string? Status { get; set; }
}
