// <copyright file="OfficesHeadlinesWorker.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NOAA.NET.Extensions;
using NOAA.NET.Interfaces;
using NOAA.NET.Services.Network;

namespace NOAA.NET.Offices;

/// <summary>
/// Public worker for the API's Offices Headlines
/// Endpoint.
/// </summary>
public sealed class OfficesHeadlinesWorker : IWorker<OfficesHeadlinesResponse>
{
    private OfficesHeadlinesClient _client = new();
    private StringBuilder _stringBuilder = new("/");

    /// <summary>
    /// Initializes a new instance of the <see cref="OfficesHeadlinesWorker"/> class.
    /// </summary>
    /// <param name="builder">Required <see cref="OfficesBuilder"/> object.</param>
    /// <exception cref="ArgumentNullException">NULL Exception.</exception>
    public OfficesHeadlinesWorker(OfficesBuilder builder)
    {
        if (builder == null)
        {
            throw new ArgumentNullException(nameof(builder));
        }
        else
        {
            this._stringBuilder.Append(builder.OfficeId.GetStringValue());
            this._stringBuilder.Append("/headlines");
            this._client.EndpointURL = this._stringBuilder.ToString();
        }
    }

    /// <summary>
    /// Calls the API's Offices Headlines Endpoint.
    /// </summary>
    /// <returns><see cref="OfficesHeadlinesResponse"/> payload.</returns>
    /// <exception cref="Exception">NULL exception.</exception>
    public async Task<OfficesHeadlinesResponse> CallEndpointAsync()
    {
        OfficesHeadlinesResponse? officesHeadlinesResponse;

        officesHeadlinesResponse = await this._client.CallAPI();

        if (officesHeadlinesResponse.Graph != null)
        {
            return officesHeadlinesResponse;
        }
        else
        {
            throw new Exception(message: "Called the Offices Headlines API Endpoint." +
                " Return payload is NULL.");
        }
    }
}
