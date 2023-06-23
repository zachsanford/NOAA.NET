// <copyright file="HealthResponse.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Health;

/// <summary>
/// Class to receive the status response from the
/// Health API Endpoint.
/// </summary>
public class HealthResponse
{
    /// <summary>
    /// Gets or sets the Status field from the API Endpoint.
    /// </summary>
    public string? Status { get; set; }
}
