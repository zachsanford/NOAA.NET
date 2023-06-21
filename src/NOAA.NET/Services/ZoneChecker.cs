// <copyright file="ZoneChecker.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using NOAA.NET.Interfaces;
using NOAA.NET.Services.Network;
using NOAA.NET.Zones;

[assembly: InternalsVisibleTo("NOAA.NET.Tests")]

namespace NOAA.NET.Services;

/// <summary>
/// Internal class used to check the validity
/// of a zone input.
/// </summary>
internal class ZoneChecker : IWorker<ZoneResponse>
{
    private ZoneClient _client = new();
    private StringBuilder _stringBuilder = new("?id=");

    /// <summary>
    /// Initializes a new instance of the <see cref="ZoneChecker"/> class.
    /// </summary>
    /// <param name="testInput"><see cref="string"/> value representing
    /// a Zone Id.</param>
    /// <exception cref="ArgumentNullException">NULL Exception.</exception>
    public ZoneChecker(string testInput)
    {
        if (testInput == null)
        {
            throw new ArgumentNullException(nameof(testInput));
        }
        else
        {
            this._stringBuilder.Append(testInput);
            this._client.EndpointURL = this._stringBuilder.ToString();
        }
    }

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

    /// <summary>
    /// Tests the zone input for validity.
    /// </summary>
    /// <returns><see cref="bool"/> value of the validity.</returns>
    internal async Task<bool> TestZone()
    {
        try
        {
            ZoneResponse testResponse = await this.CallEndpoint();

            return testResponse != null;
        }
        catch
        {
            return false;
        }
    }
}
