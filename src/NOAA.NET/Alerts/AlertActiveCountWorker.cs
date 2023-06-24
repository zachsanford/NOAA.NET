// <copyright file="AlertActiveCountWorker.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;
using System.Threading.Tasks;
using NOAA.NET.Interfaces;
using NOAA.NET.Services.Network;

namespace NOAA.NET.Alerts;

/// <summary>
/// Public worker for the API's Alert
/// Active Count Endpoint.
/// </summary>
public sealed class AlertActiveCountWorker : IWorker<AlertActiveCountResponse>
{
    private AlertActiveCountClient _client = new();

    /// <summary>
    /// Calls the API's Alert Active Count
    /// Endpoint.
    /// </summary>
    /// <returns><see cref="AlertActiveCountResponse"/> payload.</returns>
    /// <exception cref="Exception">NULL Exception.</exception>
    public async Task<AlertActiveCountResponse> CallEndpointAsync()
    {
        AlertActiveCountResponse? alertActiveCountResponse;

        alertActiveCountResponse = await this._client.CallAPI();

        if (alertActiveCountResponse != null)
        {
            return alertActiveCountResponse;
        }
        else
        {
            throw new Exception(message: "Called Alert Active Count Endpoint. Return payload is NULL.");
        }
    }
}
