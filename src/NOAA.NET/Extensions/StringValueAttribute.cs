// <copyright file="StringValueAttribute.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;

namespace NOAA.NET.Extensions;

/// <summary>
/// Custom attribute used for <see cref="Enum"/> types internally.
/// Some of the API endpoints have string values that need to be mapped to <see cref="Enum"/>
/// types. This custom attribute allows for easy string mapping to those values.
/// </summary>
internal class StringValueAttribute : Attribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="StringValueAttribute"/> class.
    /// </summary>
    /// <param name="value">The value for the attribute.</param>
    internal StringValueAttribute(string value)
    {
        this.Value = value;
    }

    /// <summary>
    /// Gets the attribute property as a <see cref="string"/> value.
    /// </summary>
    internal string Value { get; }
}
