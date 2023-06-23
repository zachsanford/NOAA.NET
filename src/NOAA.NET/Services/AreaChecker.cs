// <copyright file="AreaChecker.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NOAA.NET.Alerts;
using NOAA.NET.Interfaces;
using NOAA.NET.Services.Network;
using static NOAA.NET.Collections.Areas;

[assembly: InternalsVisibleTo("NOAA.NET.Tests")]

namespace NOAA.NET.Services;

/// <summary>
/// Internal class used to check the validity
/// of the area input.
/// </summary>
internal sealed class AreaChecker
{
    private string? _area;

    /// <summary>
    /// Initializes a new instance of the <see cref="AreaChecker"/> class.
    /// </summary>
    /// <param name="areaParameter">Two-letter <see cref="string"/> representing
    /// a state, territory or region.</param>
    /// <exception cref="ArgumentNullException">NULL Exception.</exception>
    public AreaChecker(string areaParameter)
    {
        if (areaParameter == null)
        {
            throw new ArgumentNullException(nameof(areaParameter));
        }
        else
        {
            this._area = areaParameter;
        }
    }

    /// <summary>
    /// Tests the area input against a Regex
    /// pattern and then checks to see if
    /// it exists in <see cref="NOAA.NET.Collections.Areas"/>.
    /// </summary>
    /// <returns><see cref="bool"/> value representing
    /// the validity.</returns>
    public bool TestArea()
    {
        string pattern = @"^[A-Z]{2}$";

        if (this._area != null && this._area.Length == 2)
        {
            string upper = this._area.ToUpper();

            if (Regex.IsMatch(upper, pattern))
            {
                return StatesRegion.Contains(upper);
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}