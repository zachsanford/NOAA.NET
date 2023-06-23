// <copyright file="GlossaryWorker.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;
using System.Threading.Tasks;
using NOAA.NET.Interfaces;
using NOAA.NET.Services.Network;

namespace NOAA.NET.Glossary;

/// <summary>
/// Public worker for the API's Glossary Endpoint.
/// </summary>
public sealed class GlossaryWorker : IWorker<GlossaryResponse>
{
    private readonly GlossaryClient _glossaryClient = new();

    /// <summary>
    /// Calle the API's Glossary Endpoint.
    /// </summary>
    /// <returns><see cref="GlossaryResponse"/> payload.</returns>
    /// <exception cref="Exception">NULL Exception.</exception>
    public async Task<GlossaryResponse> CallEndpoint()
    {
        GlossaryResponse? glossaryResponse;

        glossaryResponse = await this._glossaryClient.CallAPI();

        if (glossaryResponse != null)
        {
            return glossaryResponse;
        }
        else
        {
            throw new Exception(message: "Called Glossary API Endpoint. Return payload is NULL.");
        }
    }
}
