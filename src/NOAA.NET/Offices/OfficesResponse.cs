// <copyright file="OfficesResponse.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System.Text.Json.Serialization;

namespace NOAA.NET.Offices;

/// <summary>
/// A representation of the Offices Endpoint
/// response.
/// </summary>
public class OfficesResponse
{
    /// <summary>
    /// Gets or sets the
    /// <see cref="NOAA.NET.Offices.Context"/>
    /// property.
    /// </summary>
    public Context? Context { get; set; }

    /// <summary>
    /// Gets or sets the Type property.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the @Id property.
    /// </summary>
    [JsonPropertyName("@id")]
    public string? MainId { get; set; }

    /// <summary>
    /// Gets or sets the Id property.
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the Name property.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the
    /// <see cref="NOAA.NET.Offices.Address"/>
    /// property.
    /// </summary>
    public Address? Address { get; set; }

    /// <summary>
    /// Gets or sets the Telephone property.
    /// </summary>
    public string? Telephone { get; set; }

    /// <summary>
    /// Gets or sets the Fax Number property.
    /// </summary>
    public string? FaxNumber { get; set; }

    /// <summary>
    /// Gets or sets the Email property.
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Gets or sets the Same As URL property.
    /// </summary>
    public string? SameAs { get; set; }

    /// <summary>
    /// Gets or sets the NWS Region property.
    /// </summary>
    public string? NwsRegion { get; set; }

    /// <summary>
    /// Gets or sets the Parent Organization
    /// property.
    /// </summary>
    public string? ParentOrganization { get; set; }

    /// <summary>
    /// Gets or sets the Responsible Counties
    /// collection property.
    /// </summary>
    public string[]? ResponsibleCounties { get; set; }

    /// <summary>
    /// Gets or sets the Responsible Forecast
    /// Zones collection property.
    /// </summary>
    public string[]? ResponsibleForecastZones { get; set; }

    /// <summary>
    /// Gets or sets the Responsible Fire Zones
    /// collection property.
    /// </summary>
    public string[]? ResponsibleFireZones { get; set; }

    /// <summary>
    /// Gets or sets the Approved Observation
    /// Stations collection property.
    /// </summary>
    public string[]? ApprovedObservationStations { get; set; }
}
