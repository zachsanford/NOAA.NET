﻿// <copyright file="GridpointsBaseWorker.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;
using System.Text;
using System.Threading.Tasks;
using NOAA.NET.Extensions;
using NOAA.NET.Interfaces;
using NOAA.NET.Services.Network;

namespace NOAA.NET.Gridpoints.Base;

/// <summary>
/// Public worker for the API's Gridpoints Endpoint.
/// </summary>
public sealed class GridpointsBaseWorker : IWorker<GridpointsBaseResponse>
{
    private readonly GridpointsBaseBuilder _builder;
    private GridpointsBaseClient _client = new();
    private StringBuilder _stringBuilder = new("/");

    /// <summary>
    /// Initializes a new instance of the <see cref="GridpointsBaseWorker"/> class.
    /// </summary>
    /// <param name="builder">Required <see cref="GridpointsBaseBuilder"/> object.</param>
    /// <exception cref="ArgumentNullException">NULL Exception.</exception>
    public GridpointsBaseWorker(GridpointsBaseBuilder builder)
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
            this._client.EndpointURL = this._stringBuilder.ToString();
        }
    }

    /// <summary>
    /// Calls the API's Gridpoints Endpoint.
    /// </summary>
    /// <returns><see cref="GridpointsBaseResponse"/> payload.</returns>
    /// <exception cref="Exception">NULL exception and Wrong Gridpoints Exception.</exception>
    public async Task<GridpointsBaseResponse> CallEndpointAsync()
    {
        GridpointsBaseResponse? gridpointsResponse;

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
            throw new Exception(message: "Called the Gridpoints API Endpoint. Return payload is NULL.");
        }
    }
}
