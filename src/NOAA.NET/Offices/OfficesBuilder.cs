// <copyright file="OfficesBuilder.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Types;

namespace NOAA.NET.Offices;

/// <summary>
/// Builder class for the Offices Endpoint.
/// </summary>
public sealed class OfficesBuilder
{
    /// <summary>
    /// Gets or sets the <see cref="WFO"/> type,
    /// for the NWS Office Id property.
    /// </summary>
    public WFO OfficeId { get; set; }
}
