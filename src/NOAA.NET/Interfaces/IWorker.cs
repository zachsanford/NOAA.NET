// <copyright file="IWorker.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System.Threading.Tasks;

namespace NOAA.NET.Interfaces;

/// <summary>
/// Interface outlining the general
/// contract for a Worker Class.
/// </summary>
/// <typeparam name="T">Type of endpoint response.</typeparam>
internal interface IWorker<T>
{
    /// <summary>
    /// Calls the specific API Endpoint.
    /// </summary>
    /// <returns><see cref="Task"/> of a specific response.</returns>
    Task<T> CallEndpointAsync();
}
