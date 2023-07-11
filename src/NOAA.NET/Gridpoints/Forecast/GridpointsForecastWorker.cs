// <copyright file="GridpointsForecastWorker.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;
using System.Text;
using System.Threading.Tasks;
using NOAA.NET.Extensions;
using NOAA.NET.Interfaces;
using NOAA.NET.Services.Network;

namespace NOAA.NET.Gridpoints.Forecast;

/// <summary>
/// Public worker for the API's Gridpoints Forecast
/// Endpoint.
/// </summary>
public sealed class GridpointsForecastWorker : IWorker<GridpointsForecastResponse>
{
    private readonly GridpointsForecastBuilder _builder;
    private GridpointsForecastClient _client = new();
    private StringBuilder _stringBuilder = new("/");

    /// <summary>
    /// Initializes a new instance of the <see cref="GridpointsForecastWorker"/> class.
    /// </summary>
    /// <param name="builder">Required <see cref="GridpointsForecastBuilder"/> object.</param>
    /// <exception cref="ArgumentNullException">NULL Exception.</exception>
    public GridpointsForecastWorker(GridpointsForecastBuilder builder)
    {
        if (builder == null)
        {
            throw new ArgumentNullException(nameof(builder));
        }
        else
        {
            this._builder = builder;
            this._stringBuilder.Append(builder.Wfo.GetStringValue() + '/');
            this._stringBuilder.Append(builder.XCoordinate.ToString() + ',');
            this._stringBuilder.Append(builder.YCoordinate.ToString());
            this._stringBuilder.Append("/forecast");

            if (builder.IsHourly)
            {
                this._stringBuilder.Append("/hourly");
            }

            if (builder.Units != null)
            {
                this._stringBuilder.Append("?units=");
                this._stringBuilder.Append(builder.Units.GetStringValue());
            }

            this._client.EndpointURL = this._stringBuilder.ToString();
        }
    }

    /// <summary>
    /// Calls the API's Gridpoints Endpoint.
    /// </summary>
    /// <returns><see cref="GridpointsForecastResponse"/> payload.</returns>
    /// <exception cref="Exception">NULL exception and Wrong Gridpoints Exception.</exception>
    public async Task<GridpointsForecastResponse> CallEndpointAsync()
    {
        GridpointsForecastResponse? gridpointsResponse;

        try
        {
            gridpointsResponse = await this._client.CallAPI();
        }
        catch
        {
            throw new Exception(message: $"The gridpoints {this._builder.XCoordinate}," +
                $"{this._builder.YCoordinate} do not exist for the " +
                $"{this._builder.Wfo.GetStringValue()} Office. Please check you input " +
                $"and try again.");
        }

        if (gridpointsResponse.Properties != null)
        {
            return gridpointsResponse;
        }
        else
        {
            throw new Exception(message: "Called the Gridpoints Forecast API Endpoint. Return payload is NULL.");
        }
    }
}
