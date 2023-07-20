// <copyright file="ProductsWorker.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;
using System.Text;
using System.Threading.Tasks;
using NOAA.NET.Extensions;
using NOAA.NET.Interfaces;
using NOAA.NET.Services.Network;

namespace NOAA.NET.Products;

/// <summary>
/// Public worker for the API's Products Endpoint.
/// </summary>
public sealed class ProductsWorker : IWorker<ProductsResponse>
{
    private bool _isFirst = true;
    private ProductsClient _client = new();
    private StringBuilder _stringBuilder = new("?");

    /// <summary>
    /// Initializes a new instance of the <see cref="ProductsWorker"/> class.
    /// </summary>
    /// <param name="builder">Required <see cref="ProductsBuilder"/> object.</param>
    /// <exception cref="ArgumentNullException"><see cref="ProductsBuilder"/> NULL Exception.</exception>
    public ProductsWorker(ProductsBuilder builder)
    {
        if (builder == null)
        {
            throw new ArgumentNullException(nameof(builder));
        }
        else
        {
            if (builder.Location != null)
            {
                if (!this._isFirst)
                {
                    this._stringBuilder.Append("&");
                }

                this._stringBuilder.Append("location=" + builder.Location.GetStringValue());
                this._isFirst = false;
            }

            if (builder.Type != null)
            {
                if (!this._isFirst)
                {
                    this._stringBuilder.Append("&");
                }

                this._stringBuilder.Append("type=" + builder.Type.GetStringValue());
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
    }

    /// <summary>
    /// Calls the API's Products Endpoint.
    /// </summary>
    /// <returns><see cref="ProductsResponse"/> payload.</returns>
    /// <exception cref="Exception"><see cref="ProductsResponse"/> NULL Exception.</exception>
    public async Task<ProductsResponse> CallEndpointAsync()
    {
        ProductsResponse? productsResponse;

        productsResponse = await this._client.CallAPI();

        if (productsResponse.Graph != null)
        {
            return productsResponse;
        }
        else
        {
            throw new Exception(message: "Called the Products Endpoint. Return payload is NULL.");
        }
    }
}
