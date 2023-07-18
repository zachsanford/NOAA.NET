// <copyright file="OfficesWorker.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;
using System.Text;
using System.Threading.Tasks;
using NOAA.NET.Extensions;
using NOAA.NET.Interfaces;
using NOAA.NET.Services.Network;

namespace NOAA.NET.Offices;

/// <summary>
/// Public worker for the API's Offices Endpoint.
/// </summary>
public sealed class OfficesWorker : IWorker<OfficesResponse>
{
    private OfficesClient _client = new();
    private StringBuilder _stringBuilder = new("/");

    /// <summary>
    /// Initializes a new instance of the <see cref="OfficesWorker"/> class.
    /// </summary>
    /// <param name="builder">Required <see cref="OfficesBuilder"/> object.</param>
    /// <exception cref="ArgumentNullException">NULL Exception.</exception>
    public OfficesWorker(OfficesBuilder builder)
    {
        if (builder == null)
        {
            throw new ArgumentNullException(nameof(builder));
        }
        else
        {
            this._stringBuilder.Append(builder.OfficeId.GetStringValue());
            this._client.EndpointURL = this._stringBuilder.ToString();
        }
    }

    /// <summary>
    /// Calls the API's Offices Endpoint.
    /// </summary>
    /// <returns><see cref="OfficesResponse"/> payload.</returns>
    /// <exception cref="Exception">NULL exception.</exception>
    public async Task<OfficesResponse> CallEndpointAsync()
    {
        OfficesResponse? officesResponse;

        officesResponse = await this._client.CallAPI();

        if (officesResponse.Id != null)
        {
            return officesResponse;
        }
        else
        {
            throw new Exception(message: "Called the Offices API Endpoint. Return payload is NULL.");
        }
    }
}
