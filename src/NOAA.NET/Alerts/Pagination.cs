// <copyright file="Pagination.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Alerts;

/// <summary>
/// Links for retrieving more data from paged
/// data sets.
/// </summary>
public class Pagination
{
    /// <summary>
    /// Gets or sets the <see cref="string"/> property for
    /// the "next" page. Used in conjunction with the "cursor" input
    /// for the API Endpoint. A link to the next page of records.
    /// </summary>
    public string? Next { get; set; }
}
