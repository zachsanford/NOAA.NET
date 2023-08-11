// <copyright file="ObservationsWorker.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;
using System.Text;
using System.Threading.Tasks;
using NOAA.NET.Interfaces;
using NOAA.NET.Services;
using NOAA.NET.Services.Network;

namespace NOAA.NET.Stations.Observations;

/// <summary>
/// Public worker for the API's Stations/Observations Endpoint.
/// </summary>
public sealed class ObservationsWorker : IWorker<ObservationsResponse>
{
    private readonly Task? _initialization;
    private bool _isFirst = true;
    private ObservationsClient _client = new();
    private StationIdChecker? _checker;
    private StringBuilder _stringBuilder = new();

    /// <summary>
    /// Initializes a new instance of the <see cref="ObservationsWorker"/> class.
    /// This class utilizes the Stations/Observations <see cref="ObservationsBuilder"/>
    /// class. Used to interface withe the Stations/Observations Endpoint of
    /// the API.
    /// </summary>
    /// <param name="builder">Required <see cref="ObservationsBuilder"/> object.</param>
    /// <exception cref="ArgumentNullException"><see cref="ObservationsBuilder"/> NULL Exception.</exception>
    public ObservationsWorker(ObservationsBuilder builder)
    {
        this._initialization = this.InitializeAsync(builder);
    }

    /// <summary>
    /// Calls the API's Stations/Observations Endpoint.
    /// </summary>
    /// <returns><see cref="ObservationsResponse"/> payload.</returns>
    /// <exception cref="Exception">NULL Exception.</exception>
    public async Task<ObservationsResponse> CallEndpointAsync()
    {
        ObservationsResponse? observationsResponse;

        while (this._client.EndpointURL == null)
        {
            await Task.Delay(1);
        }

        observationsResponse = await this._client.CallAPI();

        if (observationsResponse != null)
        {
            return observationsResponse;
        }
        else
        {
            throw new Exception(message: "Called the Stations/Observations API Endpoint. Return payload is NULL.");
        }
    }

    private async Task InitializeAsync(ObservationsBuilder builder)
    {
        if (builder == null)
        {
            throw new ArgumentNullException(nameof(builder));
        }
        else
        {
            try
            {
                if (builder.StationId != null)
                {
                    this._checker = new(builder.StationId);

                    if (await this._checker.TestStationId())
                    {
                        this._stringBuilder.Append(builder.StationId.ToUpper());
                        this._stringBuilder.Append("/observations?");
                    }
                }
                else
                {
                    throw new Exception(message: "The Builder's StationId property is null." +
                        "Please check your builder and try again.");
                }

                if (builder.Start != null)
                {
                    if (!this._isFirst)
                    {
                        this._stringBuilder.Append("&");
                    }

                    this._stringBuilder.Append("start=");
                    this._stringBuilder.Append(builder.Start.Value.ToString("s") + 'Z');
                    this._isFirst = false;
                }

                if (builder.End != null)
                {
                    if (!this._isFirst)
                    {
                        this._stringBuilder.Append("&");
                    }

                    this._stringBuilder.Append("end=");
                    this._stringBuilder.Append(builder.End.Value.ToString("s") + 'Z');
                    this._isFirst = false;
                }

                if (builder.Limit != null)
                {
                    if (!this._isFirst)
                    {
                        this._stringBuilder.Append("&");
                    }

                    this._stringBuilder.Append("limit=");
                    this._stringBuilder.Append(builder.Limit.ToString());
                }

                this._client.EndpointURL = this._stringBuilder.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
