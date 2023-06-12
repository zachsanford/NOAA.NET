// <copyright file="GlossaryEntry.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Glossary;

/// <summary>
/// Individual Glossary Object containing key/pair values
/// for the terms within the glossary.
/// </summary>
public class GlossaryEntry
{
    /// <summary>
    /// Gets or sets the term name as a <see cref="string"/>.
    /// </summary>
    public string? Term { get; set; }

    /// <summary>
    /// Gets or sets the definition for the term as a <see cref="string"/>.
    /// </summary>
    public string? Definition { get; set; }
}