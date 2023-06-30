// <copyright file="GridpointsResponse.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Gridpoints;

/// <summary>
/// A representation of a Gridpoints Endpoint
/// response.
/// </summary>
public class GridpointsResponse
{
    /// <summary>
    /// Gets or sets the Context Property.
    /// </summary>
    public object[]? Context { get; set; }

    /// <summary>
    /// Gets or sets the Id Property.
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the Type Property.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the Geometry Property.
    /// </summary>
    public Geometry? Geometry { get; set; }

    /// <summary>
    /// Gets or sets the Properties Property.
    /// </summary>
    public Properties? Properties { get; set; }
}
