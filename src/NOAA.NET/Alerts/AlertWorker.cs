// <copyright file="AlertWorker.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;
using System.Text;
using System.Threading.Tasks;
using NOAA.NET.Extensions;
using NOAA.NET.Interfaces;
using NOAA.NET.Services;
using NOAA.NET.Services.Network;

namespace NOAA.NET.Alerts;

/// <summary>
/// Public worker for the API's Alert Endpoint.
/// </summary>
public sealed class AlertWorker : IWorker<AlertResponse>
{
    private readonly Task? _initialization;
    private bool _isFirst = true;
    private AlertClient _client = new();
    private ZoneChecker? _zoneChecker;
    private StringBuilder _stringBuilder = new("?");

    /// <summary>
    /// Initializes a new instance of the <see cref="AlertWorker"/> class.This
    /// class utilizes the Alerts <see cref="AlertBuilder"/> class. Used to
    /// interface with the Alerts Endpoint of the API.
    /// </summary>
    /// <param name="builder">Required <see cref="AlertBuilder"/> object.</param>
    /// <exception cref="ArgumentNullException"><see cref="AlertBuilder"/> NULL Exception.</exception>
    public AlertWorker(AlertBuilder builder)
    {
        this._initialization = this.InitializeAsync(builder);
    }

    /// <summary>
    /// Calls the API's Alert Endpoint.
    /// </summary>
    /// <returns><see cref="AlertResponse"/> payload.</returns>
    /// <exception cref="Exception">NULL Exception.</exception>
    public async Task<AlertResponse> CallEndpointAsync()
    {
        AlertResponse? alertResponse;

        while (this._client.EndpointURL == null)
        {
            await Task.Delay(1);
        }

        alertResponse = await this._client.CallAPI();

        if (alertResponse != null)
        {
            return alertResponse;
        }
        else
        {
            throw new Exception(message: "Called Alert API Endpoint. Return payload is NULL.");
        }
    }

    private async Task InitializeAsync(AlertBuilder builder)
    {
        if (builder == null)
        {
            throw new ArgumentNullException(nameof(builder));
        }
        else
        {
            if (builder.Status != null)
            {
                if (!this._isFirst)
                {
                    this._stringBuilder.Append("&");
                }

                this._stringBuilder.Append("status=" + builder.Status.GetStringValue());
                this._isFirst = false;
            }

            if (builder.MessageType != null)
            {
                if (!this._isFirst)
                {
                    this._stringBuilder.Append("&");
                }

                this._stringBuilder.Append("message_type=" + builder.MessageType.GetStringValue());
                this._isFirst = false;
            }

            if ((builder.Area != null && builder.Region == null && builder.Zone == null) ||
                (builder.Area != null && builder.Region != null && builder.Zone == null))
            {
                if (!this._isFirst)
                {
                    this._stringBuilder.Append("&");
                }

                this._stringBuilder.Append("area=" + builder.Area.GetStringValue());
                this._isFirst = false;
            }

            if (builder.Region != null && builder.Area == null && builder.Zone == null)
            {
                if (!this._isFirst)
                {
                    this._stringBuilder.Append("&");
                }

                this._stringBuilder.Append("region=" + builder.Region.GetStringValue());
                this._isFirst = false;
            }

            if (builder.Urgency != null)
            {
                if (!this._isFirst)
                {
                    this._stringBuilder.Append("&");
                }

                this._stringBuilder.Append("urgency=" + builder.Urgency.GetStringValue());
                this._isFirst = false;
            }

            if (builder.Severity != null)
            {
                if (!this._isFirst)
                {
                    this._stringBuilder.Append("&");
                }

                this._stringBuilder.Append("severity=" + builder.Severity.GetStringValue());
                this._isFirst = false;
            }

            if (builder.Certainty != null)
            {
                if (!this._isFirst)
                {
                    this._stringBuilder.Append("&");
                }

                this._stringBuilder.Append("certainty=" + builder.Certainty.GetStringValue());
                this._isFirst = false;
            }

            if (builder.Zone != null)
            {
                this._zoneChecker = new(builder.Zone);

                if (await this._zoneChecker.TestZone())
                {
                    if (!this._isFirst)
                    {
                        this._stringBuilder.Append("&");
                    }

                    this._stringBuilder.Append("zone=" + builder.Zone);
                    this._isFirst = false;
                }
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
    }
}
