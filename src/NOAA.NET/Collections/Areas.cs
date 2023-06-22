// <copyright file="Areas.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NOAA.NET.Collections;

/// <summary>
/// Various Area Collections.
/// </summary>
internal static class Areas
{
    /// <summary>
    /// Gets a collection of two-letter abbreviations
    /// for states, territories and regions.
    /// </summary>
    public static ReadOnlyCollection<string> StatesRegion { get; private set; } = new(new List<string>
    {
        // Alabama
        "AL",

        // Alaska
        "AK",

        // American Samoa
        "AS",

        // Arkansas
        "AR",

        // Arizona
        "AZ",

        // California
        "CA",

        // Colorado
        "CO",

        // Connecticut
        "CT",

        // Delaware
        "DE",

        // Washington D.C.
        "DC",

        // Florida
        "FL",

        // Georgia
        "GA",

        // Guam
        "GU",

        // Hawaii
        "HI",

        // Idaho
        "ID",

        // Illinois
        "IL",

        // Indiana
        "IN",

        // Iowa
        "IA",

        // Kansas
        "KS",

        // Kentucky
        "KY",

        // Louisiana
        "LA",

        // Maine
        "ME",

        // Maryland
        "MD",

        // Massachusetts
        "MA",

        // Michigan
        "MI",

        // Minnesota
        "MN",

        // Mississippi
        "MS",

        // Missouri
        "MO",

        // Montana
        "MT",

        // Nebraska
        "NE",

        // Nevada
        "NV",

        // New Hampshire
        "NH",

        // New Jersey
        "NJ",

        // New Mexico
        "NM",

        // New York
        "NY",

        // North Carolina
        "NC",

        // North Dakota
        "ND",

        // Ohio
        "OH",

        // Oklahoma
        "OK",

        // Oregon
        "OR",

        // Pennsylvania
        "PA",

        // Puerto Rico
        "PR",

        // Rhode Island
        "RI",

        // South Carolina
        "SC",

        // South Dakota
        "SD",

        // Tennessee
        "TN",

        // Texas
        "TX",

        // Utah
        "UT",

        // Vermont
        "VT",

        // Virgin Islands
        "VI",

        // Virginia
        "VA",

        // Washington
        "WA",

        // West Virginia
        "WV",

        // Wisconsin
        "WI",

        // Wyoming
        "WY",

        // Commonwealth of the Northern Marianas
        "MP",

        // Republic of Palau
        "PW",

        // Federated States of Micronesia
        "FM",

        // Republic of the Marshall Islands
        "MH",

        // West N. Atlantic Ocean
        "AM",

        // Northwest N. Atlantic Ocean
        "AN",

        // Gulf of Mexico
        "GM",

        // Lake St. Clair
        "LC",

        // Lake Erie
        "LE",

        // Lake Huron
        "LH",

        // Lake Michigan
        "LM",

        // Lake Ontario
        "LO",

        // Lake Superior
        "LS",

        // Central Pacific Ocean
        "PH",

        // N. Pacific Ocean Near Alaska
        "PK",

        // Western Pacific Ocean
        "PM",

        // S. Central Pacific Ocean
        "PS",

        // Eastern N. Pacific Ocean
        "PZ",

        // St. Lawrence River
        "SL"
    });
}
