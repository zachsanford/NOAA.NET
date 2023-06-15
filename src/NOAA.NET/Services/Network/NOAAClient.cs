// <copyright file="NOAAClient.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace NOAA.NET.Services.Network;

/// <summary>
/// Abstract class for all of the endpoint HTTP Clients.
/// </summary>
/// <typeparam name="T">Type of endpoint.</typeparam>
public abstract class NOAAClient<T>
{
    /// <summary>
    /// Gets an abstract property that MUST be overridden.
    /// </summary>
    protected abstract string BaseURL { get; }

    /// <summary>
    /// Gets the Endpoint Type.
    /// </summary>
    protected abstract string EndpointType { get; }

    /// <summary>
    /// Calls a specific API endpoint.
    /// </summary>
    /// <returns>The specific model for that endpoint.</returns>
    /// <exception cref="Exception">Error trying to call the endpoint.</exception>
    public virtual async Task<T> CallAPI()
    {
        T? apiResponse = default(T);

        using (HttpClient httpClient = new HttpClient())
        {
            httpClient.DefaultRequestHeaders.Add("User-Agent", "NOAA.NET Client");

            try
            {
                using (HttpResponseMessage response = await httpClient.GetAsync(this.BaseURL))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        apiResponse = await response.Content.ReadFromJsonAsync<T>();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(message: $"Error trying to reach the {this.EndpointType} API endpoint. Exception: {ex}.", ex.InnerException);
            }
        }

        return apiResponse!;
    }
}
