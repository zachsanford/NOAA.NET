// <copyright file="SlowRequestHandler.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace NOAA.NET.Extensions;

/// <summary>
/// Http Request Handler that delays the HTTP request
/// by a certain amount of time.
/// </summary>
internal class SlowRequestHandler : DelegatingHandler
{
    private readonly TimeSpan _delay;

    /// <summary>
    /// Initializes a new instance of the <see cref="SlowRequestHandler"/> class.
    /// </summary>
    /// <param name="delay"><see cref="TimeSpan"/> delay in milliseconds.</param>
    public SlowRequestHandler(TimeSpan delay)
    {
        this._delay = delay;
    }

    /// <summary>
    /// Custom override for the <see cref="HttpClient"/> method
    /// SendAsync(). Introduces a delay when making calls.
    /// </summary>
    /// <param name="request">Original <see cref="HttpRequestMessage"/>.</param>
    /// <param name="cancellationToken">Cancellation Token.</param>
    /// <returns>A delayed. <see cref="HttpResponseMessage"/>.</returns>
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        await Task.Delay(this._delay, cancellationToken);
        HttpResponseMessage response = await base.SendAsync(request, cancellationToken);

        return response;
    }
}
