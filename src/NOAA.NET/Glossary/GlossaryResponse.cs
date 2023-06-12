// <copyright file="GlossaryResponse.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Glossary;

/// <summary>
/// Usable model for the Glossary API Endpoint.
/// </summary>
public class GlossaryResponse
{
    /// <summary>
    /// Gets or sets an array of Glossary Objects.
    /// </summary>
    public GlossaryEntry[]? Glossary { get; set; }
}
