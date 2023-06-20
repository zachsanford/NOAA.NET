// <copyright file="ZoneChecker.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;
using System.Threading.Tasks;
using NOAA.NET.Interfaces;
using NOAA.NET.Services.Network;
using NOAA.NET.Zones;

namespace NOAA.NET.Services;

/// <summary>
/// Internal class used to check the validity
/// of a zone input.
/// </summary>
internal class ZoneChecker : IWorker<ZoneResponse>
{
    private ZoneClient _client = new();

    /// <summary>
    /// Calls the API's Zones Endpoint.
    /// </summary>
    /// <returns><see cref="ZoneResponse"/> payload.</returns>
    /// <exception cref="Exception">NULL Exception.</exception>
    public async Task<ZoneResponse> CallEndpoint()
    {
        ZoneResponse? zoneResponse;

        zoneResponse = await this._client.CallAPI();

        if (zoneResponse != null)
        {
            return zoneResponse;
        }
        else
        {
            throw new Exception(message: "Called the Zones API Endpoint. Return payload is NULL.");
        }
    }
}
