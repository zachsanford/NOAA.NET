// <copyright file="HealthWorker.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;
using System.Threading.Tasks;
using NOAA.NET.Interfaces;
using NOAA.NET.Services.Network;

namespace NOAA.NET.Health;

/// <summary>
/// Public worker for the API's Health Endpoint.
/// </summary>
public sealed class HealthWorker : IWorker<HealthResponse>
{
    private readonly HealthClient _healthClient = new();

    /// <summary>
    /// Calls the API's Health Endpoint.
    /// </summary>
    /// <returns><see cref="HealthResponse"/> payload.</returns>
    /// <exception cref="System.Exception">NULL Exception.</exception>
    public async Task<HealthResponse> CallEndpoint()
    {
        HealthResponse? healthResponse;

        healthResponse = await this._healthClient.CallAPI();

        if (healthResponse != null)
        {
            return healthResponse;
        }
        else
        {
            throw new Exception(message: "Called Health API Endpoint. Return payload is NULL.");
        }
    }
}
