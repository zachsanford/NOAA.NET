// <copyright file="EnumExtensions.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;
using System.Reflection;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("NOAA.NET.Tests")]

namespace NOAA.NET.Extensions;

/// <summary>
/// Internal <see cref="Enum"/> extension that allows for custom
/// <see cref="string"/> value attributes. This extension method
/// gets that value.
/// </summary>
internal static class EnumExtensions
{
    /// <summary>
    /// Extension method that gets the custom attribute value
    /// for an internal <see cref="Enum"/> type.
    /// </summary>
    /// <param name="value"><see cref="Enum"/>.</param>
    /// <returns><see cref="string"/> value for that <see cref="Enum"/> type value.</returns>
    internal static string GetStringValue(this Enum value)
    {
        Type type = value.GetType();
        FieldInfo fieldInfo = type.GetField(value.ToString())!;
        StringValueAttribute[]? attributes = fieldInfo.GetCustomAttributes(typeof(StringValueAttribute), false) as StringValueAttribute[];

        return attributes?.Length > 0 ? attributes[0].Value : string.Empty;
    }
}
