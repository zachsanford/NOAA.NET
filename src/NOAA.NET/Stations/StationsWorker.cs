﻿// <copyright file="StationsWorker.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;
using System.Text;
using System.Threading.Tasks;
using NOAA.NET.Extensions;
using NOAA.NET.Interfaces;

namespace NOAA.NET.Stations;

/// <summary>
/// Public worker for the API's Stations Endpoint.
/// </summary>
public sealed class StationsWorker : IWorker<StationsResponse>
{
    private readonly Task? _initialization;
    private bool _isFirst = true;
    private StringBuilder _stringBuilder = new("?");

    /// <summary>
    /// Initializes a new instance of the <see cref="StationsWorker"/> class.This
    /// class utilizes the Stations <see cref="StationsBuilder"/> class. Used to
    /// interface with the Stations Endpoint of the API.
    /// </summary>
    /// <param name="builder">Required <see cref="StationsBuilder"/> object.</param>
    /// <exception cref="ArgumentNullException"><see cref="StationsBuilder"/> NULL Exception.</exception>
    public StationsWorker(StationsBuilder builder)
    {
        this._initialization = this.InitializeAsync(builder);
    }

    /// <summary>
    /// NEED TO IMPLEMENT.
    /// </summary>
    /// <returns>NEED.</returns>
    /// <exception cref="System.NotImplementedException">NEEDED.</exception>
    public Task<StationsResponse> CallEndpointAsync()
    {
        throw new System.NotImplementedException();
    }

    private async Task InitializeAsync(StationsBuilder builder)
    {
        if (builder == null)
        {
            throw new ArgumentNullException(nameof(builder));
        }
        else
        {
            if (builder.Id != null)
            {
                if (!this._isFirst)
                {
                    this._stringBuilder.Append("&");
                }

                // TODO
                // Add a StationsId Checker to check the validity
                // of the Builder's Id Property.
            }

            if (builder.State != null)
            {
                if (!this._isFirst)
                {
                    this._stringBuilder.Append("&");
                }

                this._stringBuilder.Append("state=");
                this._stringBuilder.Append(builder.State.GetStringValue());
                this._isFirst = false;
            }

            if (builder.Limit != null)
            {
                if (builder.Limit > 500)
                {
                    throw new Exception(message: "The StationsBuilder Limit is greater than 500." +
                        "The MAX value for this input is 500. Please check your builder and try again.");
                }
                else
                {
                    if (!this._isFirst)
                    {
                        this._stringBuilder.Append("&");
                    }

                    this._stringBuilder.Append("limit=");
                    this._stringBuilder.Append(builder.Limit.ToString());
                    this._isFirst = false;
                }
            }

            if (builder.Cursor != null)
            {
                if (!this._isFirst)
                {
                    this._stringBuilder.Append("&");
                }

                this._stringBuilder.Append("cursor=");
                this._stringBuilder.Append(builder.Cursor);
                this._isFirst = false;
            }
        }
    }
}
