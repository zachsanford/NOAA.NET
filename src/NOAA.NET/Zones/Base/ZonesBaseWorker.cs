// <copyright file="ZonesBaseWorker.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;
using System.Text;
using System.Threading.Tasks;
using NOAA.NET.Extensions;
using NOAA.NET.Interfaces;
using NOAA.NET.Services;
using NOAA.NET.Services.Network;

namespace NOAA.NET.Zones.Base;

/// <summary>
/// Public worker for the API's Base Zones Endpoint.
/// </summary>
public sealed class ZonesBaseWorker : IWorker<ZonesBaseResponse>
{
    private readonly Task? _initialization;
    private bool _isFirst = true;
    private ZonesBaseClient _client = new();
    private ZoneChecker? _zoneChecker;
    private StringBuilder _stringBuilder = new("?");

    /// <summary>
    /// Initializes a new instance of the <see cref="ZonesBaseWorker"/> class.This
    /// class utilizes the Zones Base <see cref="ZonesBaseBuilder"/> class. Used to
    /// interface with the Base Zones Endpoint of the API.
    /// </summary>
    /// <param name="builder">Required <see cref="ZonesBaseBuilder"/> object.</param>
    /// <exception cref="ArgumentNullException"><see cref="ZonesBaseBuilder"/> NULL Exception.</exception>
    public ZonesBaseWorker(ZonesBaseBuilder builder)
    {
        this._initialization = this.InitializeAsync(builder);
    }

    /// <summary>
    /// Calls the API's Base Zones Endpoint.
    /// </summary>
    /// <returns><see cref="ZonesBaseResponse"/> payload.</returns>
    /// <exception cref="Exception">NULL Exception.</exception>
    public async Task<ZonesBaseResponse> CallEndpointAsync()
    {
        ZonesBaseResponse? zonesBaseResponse;

        while (this._client.EndpointURL == null)
        {
            await Task.Delay(1);
        }

        zonesBaseResponse = await this._client.CallAPI();

        if (zonesBaseResponse != null)
        {
            return zonesBaseResponse;
        }
        else
        {
            throw new Exception(message: "Called Base Zones API Endpoint. Return payload is NULL.");
        }
    }

    private async Task InitializeAsync(ZonesBaseBuilder builder)
    {
        if (builder == null)
        {
            throw new ArgumentNullException(nameof(builder));
        }
        else
        {
            try
            {
                if (builder.ZoneId != null)
                {
                    this._zoneChecker = new(builder.ZoneId);

                    if (await this._zoneChecker.TestZone())
                    {
                        if (!this._isFirst)
                        {
                            this._stringBuilder.Append("&");
                        }

                        this._stringBuilder.Append("id=" + builder.ZoneId);
                        this._isFirst = false;
                    }
                }

                if (builder.Type != null &&
                        builder.ZoneId == null)
                {
                    if (!this._isFirst)
                    {
                        this._stringBuilder.Append("&");
                    }

                    this._stringBuilder.Append("type=" + builder.Type.GetStringValue());
                    this._isFirst = false;
                }

                if (builder.Point != null &&
                        builder.ZoneId == null)
                {
                    if (!this._isFirst)
                    {
                        this._stringBuilder.Append("&");
                    }

                    this._stringBuilder.Append("point=" + builder.Point);
                    this._isFirst = false;
                }

                if (builder.IncludeGeometry != null)
                {
                    if (!this._isFirst)
                    {
                        this._stringBuilder.Append("&");
                    }

                    this._stringBuilder.Append("include_geometry=" + builder.IncludeGeometry.Value.ToString().ToLower());
                    this._isFirst = false;
                }

                if (builder.Limit != null)
                {
                    if (!this._isFirst)
                    {
                        this._stringBuilder.Append("&");
                    }

                    this._stringBuilder.Append("limit=" + builder.Limit.ToString());
                    this._isFirst = false;
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
