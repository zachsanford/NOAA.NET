// <copyright file="SigmetsWorker.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;
using System.Text;
using System.Threading.Tasks;
using NOAA.NET.Interfaces;
using NOAA.NET.Services.Network;
using static NOAA.NET.Services.AtsuChecker;

namespace NOAA.NET.Aviation.Sigmets;

/// <summary>
/// Public worker for the API's Aviation/SIGMETs Endpoint.
/// </summary>
public sealed class SigmetsWorker : IWorker<SigmetsResponse>
{
    private string? _endpointPropertiesURL;
    private bool _isFirst = true;
    private SigmetsClient _client = new();
    private StringBuilder _stringBuilder = new("?");

    /// <summary>
    /// Initializes a new instance of the <see cref="SigmetsWorker"/> class.
    /// </summary>
    public SigmetsWorker()
    {
        this._client.EndpointURL = string.Empty;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SigmetsWorker"/> class.
    /// </summary>
    /// <param name="builder"><see cref="SigmetsBuilder"/> object.</param>
    /// <exception cref="Exception">Not valid input.</exception>
    public SigmetsWorker(SigmetsBuilder builder)
    {
        if (builder == null)
        {
            this._client.EndpointURL = string.Empty;
        }
        else
        {
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

            if (builder.Date != null)
            {
                if (!this._isFirst)
                {
                    this._stringBuilder.Append("&");
                }

                this._stringBuilder.Append("date=");
                this._stringBuilder.Append(builder.Date.Value.ToString("yyyy-MM-dd"));
                this._isFirst = false;
            }

            if (builder.Atsu != null)
            {
                if (!this._isFirst)
                {
                    this._stringBuilder.Append("&");
                }

                if (Check(builder.Atsu))
                {
                    this._stringBuilder.Append("atsu=");
                    this._stringBuilder.Append(builder.Atsu);
                    this._isFirst = false;
                }
                else
                {
                    throw new Exception(message: $"The {nameof(builder.Atsu)} value of {builder.Atsu} is not a valid input." +
                        $"Please check your input and try again.");
                }
            }

            if (builder.Sequence != null)
            {
                if (!this._isFirst)
                {
                    this._stringBuilder.Append("&");
                }

                this._stringBuilder.Append("sequence=");
                this._stringBuilder.Append(builder.Sequence);
                this._isFirst = false;
            }

            this._endpointPropertiesURL = this._stringBuilder.ToString();
            this._client.EndpointURL = this._endpointPropertiesURL;
        }
    }

    /// <summary>
    /// Calls the API's Aviation/SIGMETs Endpoint.
    /// </summary>
    /// <returns><see cref="SigmetsResponse"/> payload.</returns>
    /// <exception cref="Exception">NULL Exception.</exception>
    public async Task<SigmetsResponse> CallEndpointAsync()
    {
        SigmetsResponse? sigmetsResponse;

        while (this._client.EndpointURL == null)
        {
            await Task.Delay(1);
        }

        sigmetsResponse = await this._client.CallAPI();

        if (sigmetsResponse != null)
        {
            return sigmetsResponse;
        }
        else
        {
            throw new Exception(message: "Called Aviation/SIGMETs API Endpoint. Return payload is NULL.");
        }
    }
}