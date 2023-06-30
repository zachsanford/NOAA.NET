// <copyright file="AtsuChecker.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System.Text.RegularExpressions;

namespace NOAA.NET.Services;

/// <summary>
/// Internal static class used to check the validity
/// of a ATSU input.
/// </summary>
internal static class AtsuChecker
{
    /// <summary>
    /// Tests the input string against a regex
    /// pattern.
    /// </summary>
    /// <param name="testString"><see cref="string"/> input.</param>
    /// <returns><see cref="bool"/> representation of it is a match.</returns>
    internal static bool Check(string testString)
    {
        string pattern = @"^[A-Z]{3,4}$";

        return Regex.IsMatch(testString, pattern);
    }
}
