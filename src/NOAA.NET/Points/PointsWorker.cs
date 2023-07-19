// <copyright file="PointsWorker.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;
using System.Text;
using System.Threading.Tasks;
using NOAA.NET.Interfaces;
using NOAA.NET.Services.Network;

namespace NOAA.NET.Points;

/// <summary>
/// Public worker for the API's Points Endpoint.
/// </summary>
public sealed class PointsWorker : IWorker<PointsResponse>
{
    private PointsClient _client = new();
    private StringBuilder _stringBuilder = new("/");

    /// <summary>
    /// Initializes a new instance of the <see cref="PointsWorker"/> class.
    /// </summary>
    /// <param name="builder">Required <see cref="PointsBuilder"/> object.</param>
    /// <exception cref="ArgumentNullException">NULL Exception.</exception>
    public PointsWorker(PointsBuilder builder)
    {
        if (builder == null)
        {
            throw new ArgumentNullException(nameof(builder));
        }
        else
        {
            this._stringBuilder.Append(builder.Point);
            this._client.EndpointURL = this._stringBuilder.ToString();
        }
    }

    /// <summary>
    /// Calls the API's Points Endpoint.
    /// </summary>
    /// <returns><see cref="PointsResponse"/> payload.</returns>
    /// <exception cref="Exception">NULL Exception.</exception>
    public async Task<PointsResponse> CallEndpointAsync()
    {
        PointsResponse? pointsResponse;

        pointsResponse = await this._client.CallAPI();

        if (pointsResponse.Geometry != null)
        {
            return pointsResponse;
        }
        else
        {
            throw new Exception(message: "Called the Points API Endpoint. Return payload is NULL.");
        }
    }
}
