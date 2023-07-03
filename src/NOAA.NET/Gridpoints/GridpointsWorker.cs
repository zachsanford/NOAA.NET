// <copyright file="GridpointsWorker.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;
using System.Text;
using System.Threading.Tasks;
using NOAA.NET.Extensions;
using NOAA.NET.Interfaces;
using NOAA.NET.Services.Network;

namespace NOAA.NET.Gridpoints;

/// <summary>
/// Public worker for the API's Gridpoints Endpoint.
/// </summary>
public sealed class GridpointsWorker : IWorker<GridpointsResponse>
{
    private readonly GridpointsBuilder _gridpointsBuilder;
    private string? _endpointPropertiesURL;
    private GridpointsClient _client = new();
    private StringBuilder _stringBuilder = new("/");

    /// <summary>
    /// Initializes a new instance of the <see cref="GridpointsWorker"/> class.
    /// </summary>
    /// <param name="builder">Required <see cref="GridpointsBuilder"/> object.</param>
    public GridpointsWorker(GridpointsBuilder builder)
    {
        if (builder == null)
        {
            throw new ArgumentNullException(nameof(builder));
        }
        else
        {
            this._gridpointsBuilder = builder;
            this._stringBuilder.Append(builder.Wfo.GetStringValue() + '/');
            this._stringBuilder.Append(builder.XCoordinate.ToString() + ',');
            this._stringBuilder.Append(builder.YCoordinate.ToString());
            this._endpointPropertiesURL = this._stringBuilder.ToString();
            this._client.EndpointURL = this._endpointPropertiesURL;
        }
    }

    /// <summary>
    /// Calls the API's Gridpoints Endpoint.
    /// </summary>
    /// <returns><see cref="GridpointsResponse"/> payload.</returns>
    /// <exception cref="Exception">NULL exception and Wrong Gridpoints Exception.</exception>
    public async Task<GridpointsResponse> CallEndpointAsync()
    {
        GridpointsResponse? gridpointsResponse;

        try
        {
            gridpointsResponse = await this._client.CallAPI();
        }
        catch
        {
            throw new Exception(message: $"The gridpoints {this._gridpointsBuilder.XCoordinate}," +
                $"{this._gridpointsBuilder.YCoordinate} do not exist for the " +
                $"{this._gridpointsBuilder.Wfo.GetStringValue()} Office. Please check you input " +
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
