// <copyright file="CwsusWorker.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;
using System.Text;
using System.Threading.Tasks;
using NOAA.NET.Alerts;
using NOAA.NET.Extensions;
using NOAA.NET.Interfaces;
using NOAA.NET.Services.Network;

namespace NOAA.NET.Aviation;

/// <summary>
/// Public worker for the API's Aviation/CWSUS
/// Endpoint.
/// </summary>
public sealed class CwsusWorker : IWorker<CwsusResponse>
{
    private string? _endpointPropertiesURL;
    private CwsusClient _client = new();
    private StringBuilder _stringBuilder = new("/");

    /// <summary>
    /// Initializes a new instance of the <see cref="CwsusWorker"/> class.
    /// </summary>
    /// <param name="builder">Required <see cref="CwsusBuilder"/> object.</param>
    /// <exception cref="ArgumentNullException"><see cref="CwsusBuilder"/> NULL Exception.</exception>
    public CwsusWorker(CwsusBuilder builder)
    {
        if (builder == null)
        {
            throw new ArgumentNullException(nameof(builder));
        }
        else
        {
            this._stringBuilder.Append(builder.CwsuId.GetStringValue());
            this._stringBuilder.Append("/cwas");
            this._endpointPropertiesURL = this._stringBuilder.ToString();
            this._client.EndpointURL = this._endpointPropertiesURL;
        }
    }

    /// <summary>
    /// Calls the API's Aviation/CWSUS Endpoint.
    /// </summary>
    /// <returns><see cref="CwsusResponse"/> payload.</returns>
    /// <exception cref="Exception">NULL Exception.</exception>
    public async Task<CwsusResponse> CallEndpointAsync()
    {
        CwsusResponse? cwsusResponse;

        cwsusResponse = await this._client.CallAPI();

        if (cwsusResponse != null)
        {
            return cwsusResponse;
        }
        else
        {
            throw new Exception(message: $"Called Aviation CWSUS API Endpoint. Return payload is NULL.");
        }
    }
}
