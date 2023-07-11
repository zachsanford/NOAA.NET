// <copyright file="StationIdChecker.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using NOAA.NET.Interfaces;
using NOAA.NET.Services.Network;
using NOAA.NET.Stations;

[assembly: InternalsVisibleTo("NOAA.NET.Tests")]

namespace NOAA.NET.Services;

/// <summary>
/// Internal class used to check the validity
/// of the Station Id input for the Stations
/// Endpoint of the API.
/// </summary>
internal sealed class StationIdChecker : IWorker<StationsResponse>
{
    private StationsClient _client = new();
    private StringBuilder _stringBuilder = new("?id=");

    /// <summary>
    /// Initializes a new instance of the <see cref="StationIdChecker"/> class.
    /// </summary>
    /// <param name="stationIdParameter"><see cref="string"/> value representing
    /// a Station Id.</param>
    /// <exception cref="ArgumentNullException">NULL Exception.</exception>
    public StationIdChecker(string stationIdParameter)
    {
        if (stationIdParameter == null)
        {
            throw new ArgumentNullException(nameof(stationIdParameter));
        }
        else
        {
            this._stringBuilder.Append(stationIdParameter.ToUpper());
            this._client.EndpointURL = this._stringBuilder.ToString();
        }
    }

    /// <summary>
    /// Calls the API's Stations Endpoint.
    /// </summary>
    /// <returns><see cref="StationsResponse"/> payload.</returns>
    /// <exception cref="Exception">NULL Exception.</exception>
    public async Task<StationsResponse> CallEndpointAsync()
    {
        StationsResponse? stationsResponse;

        stationsResponse = await this._client.CallAPI();

        if (stationsResponse != null)
        {
            return stationsResponse;
        }
        else
        {
            throw new Exception(message: "Called the Stations API Endpoint. Return payload is NULL.");
        }
    }

    /// <summary>
    /// Tests the validity of the stationid input.
    /// </summary>
    /// <returns><see cref="bool"/> value of the validity.</returns>
    internal async Task<bool> TestStationId()
    {
        try
        {
            StationsResponse testResponse = await this.CallEndpointAsync();

            if (testResponse.ObservationStations != null)
            {
                return testResponse.ObservationStations.Length > 0;
            }
            else
            {
                return false;
            }
        }
        catch
        {
            return false;
        }
    }
}
