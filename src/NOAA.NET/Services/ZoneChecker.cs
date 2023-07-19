// <copyright file="ZoneChecker.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NOAA.NET.Interfaces;
using NOAA.NET.Services.Network;
using NOAA.NET.Zones;

[assembly: InternalsVisibleTo("NOAA.NET.Tests")]

namespace NOAA.NET.Services;

/// <summary>
/// Internal class used to check the validity
/// of a zone input.
/// </summary>
internal sealed class ZoneChecker : IWorker<ZoneResponse>
{
    private ZoneClient _client = new();
    private StringBuilder _stringBuilder = new("?id=");

    /// <summary>
    /// Initializes a new instance of the <see cref="ZoneChecker"/> class.
    /// </summary>
    /// <param name="zoneParameter"><see cref="string"/> value representing
    /// a Zone Id.</param>
    /// <exception cref="ArgumentNullException">NULL Exception.</exception>
    public ZoneChecker(string zoneParameter)
    {
        if (zoneParameter == null)
        {
            throw new ArgumentNullException(nameof(zoneParameter));
        }
        else
        {
            if (this.TestString(zoneParameter))
            {
                this._stringBuilder.Append(zoneParameter.ToUpper());
                this._client.EndpointURL = this._stringBuilder.ToString();
            }
            else
            {
                throw new Exception(message: $"INCORRECT INPUT: {zoneParameter} does not match the correct pattern.");
            }
        }
    }

    /// <summary>
    /// Calls the API's Zones Endpoint.
    /// </summary>
    /// <returns><see cref="ZoneResponse"/> payload.</returns>
    /// <exception cref="Exception">NULL Exception.</exception>
    public async Task<ZoneResponse> CallEndpointAsync()
    {
        ZoneResponse? zoneResponse;

        zoneResponse = await this._client.CallAPI();

        if (zoneResponse != null)
        {
            return zoneResponse;
        }
        else
        {
            throw new Exception(message: "Called the Zones API Endpoint. Return payload is NULL.");
        }
    }

    /// <summary>
    /// Tests the validity of the zone input.
    /// </summary>
    /// <returns><see cref="bool"/> value of the validity.</returns>
    internal async Task<bool> TestZone()
    {
        try
        {
            ZoneResponse testResponse = await this.CallEndpointAsync();

            if (testResponse.Features != null)
            {
                return testResponse.Features.Length > 0;
            }
            else
            {
                return false;
            }
        }
        catch
        {
            return false;
        }
    }

    private bool TestString(string s)
    {
        string pattern = @"^(A[KLMNRSZ]|C[AOT]|D[CE]|F[LM]|G[AMU]|I[ADLN]|K[SY]
                |L[ACEHMOS]|M[ADEHINOPST]|N[CDEHJMVY]|O[HKR]|P[AHKMRSWZ]|S[CDL]
                |T[NX]|UT|V[AIT]|W[AIVY]|[HR]I)[CZ]\d{3}$";

        if (s.Length == 6)
        {
            string upper = s.ToUpper();

            return Regex.IsMatch(upper, pattern);
        }
        else
        {
            return false;
        }
    }
}
