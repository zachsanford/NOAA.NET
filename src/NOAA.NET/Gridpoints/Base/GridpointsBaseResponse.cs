// <copyright file="GridpointsBaseResponse.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Gridpoints.Base;

/// <summary>
/// A representation of a Gridpoints Endpoint
/// response.
/// </summary>
public class GridpointsBaseResponse
{
    /// <summary>
    /// Gets or sets the Context property.
    /// </summary>
    public object[]? Context { get; set; }

    /// <summary>
    /// Gets or sets the Id property.
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the Type property.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the Geometry property.
    /// </summary>
    public Geometry? Geometry { get; set; }

    /// <summary>
    /// Gets or sets the Properties property.
    /// </summary>
    public Properties? Properties { get; set; }
}
