// <copyright file="Areas.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Extensions;

namespace NOAA.NET.Types;

/// <summary>
/// State/Region/Area type for various endpoint
/// inputs.
/// </summary>
public enum Areas
{
    /// <summary>
    /// Alabama.
    /// </summary>
    [StringValue("AL")]
    AL,

    /// <summary>
    /// Alaska.
    /// </summary>
    [StringValue("AK")]
    AK,

    /// <summary>
    /// American Samoa.
    /// </summary>
    [StringValue("AS")]
    AS,

    /// <summary>
    /// Arkansas.
    /// </summary>
    [StringValue("AR")]
    AR,

    /// <summary>
    /// Arizona.
    /// </summary>
    [StringValue("AZ")]
    AZ,

    /// <summary>
    /// California.
    /// </summary>
    [StringValue("CA")]
    CA,

    /// <summary>
    /// Colorado.
    /// </summary>
    [StringValue("CO")]
    CO,

    /// <summary>
    /// Connecticut.
    /// </summary>
    [StringValue("CT")]
    CT,

    /// <summary>
    /// Delaware.
    /// </summary>
    [StringValue("DE")]
    DE,

    /// <summary>
    /// Washington D.C.
    /// </summary>
    [StringValue("DC")]
    DC,

    /// <summary>
    /// Florida.
    /// </summary>
    [StringValue("FL")]
    FL,

    /// <summary>
    /// Georgia.
    /// </summary>
    [StringValue("GA")]
    GA,

    /// <summary>
    /// Guam.
    /// </summary>
    [StringValue("GU")]
    GU,

    /// <summary>
    /// Hawaii.
    /// </summary>
    [StringValue("HI")]
    HI,

    /// <summary>
    /// Idaho.
    /// </summary>
    [StringValue("ID")]
    ID,

    /// <summary>
    /// Illinois.
    /// </summary>
    [StringValue("IL")]
    IL,

    /// <summary>
    /// Indiana.
    /// </summary>
    [StringValue("IN")]
    IN,

    /// <summary>
    /// Iowa.
    /// </summary>
    [StringValue("IA")]
    IA,

    /// <summary>
    /// Kansas.
    /// </summary>
    [StringValue("KS")]
    KS,

    /// <summary>
    /// Kentucky.
    /// </summary>
    [StringValue("KY")]
    KY,

    /// <summary>
    /// Louisiana.
    /// </summary>
    [StringValue("LA")]
    LA,

    /// <summary>
    /// Maine.
    /// </summary>
    [StringValue("ME")]
    ME,

    /// <summary>
    /// Maryland.
    /// </summary>
    [StringValue("MD")]
    MD,

    /// <summary>
    /// Massachusetts.
    /// </summary>
    [StringValue("MA")]
    MA,

    /// <summary>
    /// Michigan.
    /// </summary>
    [StringValue("MI")]
    MI,

    /// <summary>
    /// Minnesota.
    /// </summary>
    [StringValue("MN")]
    MN,

    /// <summary>
    /// Mississippi.
    /// </summary>
    [StringValue("MS")]
    MS,

    /// <summary>
    /// Missouri.
    /// </summary>
    [StringValue("MO")]
    MO,

    /// <summary>
    /// Montana.
    /// </summary>
    [StringValue("MT")]
    MT,

    /// <summary>
    /// Nebraska.
    /// </summary>
    [StringValue("NE")]
    NE,

    /// <summary>
    /// Nevada.
    /// </summary>
    [StringValue("NV")]
    NV,

    /// <summary>
    /// New Hampshire.
    /// </summary>
    [StringValue("NH")]
    NH,

    /// <summary>
    /// New Jersey.
    /// </summary>
    [StringValue("NJ")]
    NJ,

    /// <summary>
    /// New Mexico.
    /// </summary>
    [StringValue("NM")]
    NM,

    /// <summary>
    /// New York.
    /// </summary>
    [StringValue("NY")]
    NY,

    /// <summary>
    /// North Carolina.
    /// </summary>
    [StringValue("NC")]
    NC,

    /// <summary>
    /// North Dakota.
    /// </summary>
    [StringValue("ND")]
    ND,

    /// <summary>
    /// Ohio.
    /// </summary>
    [StringValue("OH")]
    OH,

    /// <summary>
    /// Oklahoma.
    /// </summary>
    [StringValue("OK")]
    OK,

    /// <summary>
    /// Oregon.
    /// </summary>
    [StringValue("OR")]
    OR,

    /// <summary>
    /// Pennslyvania.
    /// </summary>
    [StringValue("PA")]
    PA,

    /// <summary>
    /// Puerto Rico.
    /// </summary>
    [StringValue("PR")]
    PR,

    /// <summary>
    /// Rhode Island.
    /// </summary>
    [StringValue("RI")]
    RI,

    /// <summary>
    /// South Carolina.
    /// </summary>
    [StringValue("SC")]
    SC,

    /// <summary>
    /// South Dakota.
    /// </summary>
    [StringValue("SD")]
    SD,

    /// <summary>
    /// Tennessee.
    /// </summary>
    [StringValue("TN")]
    TN,

    /// <summary>
    /// Texas.
    /// </summary>
    [StringValue("TX")]
    TX,

    /// <summary>
    /// Utah.
    /// </summary>
    [StringValue("UT")]
    UT,

    /// <summary>
    /// Vermont.
    /// </summary>
    [StringValue("VT")]
    VT,

    /// <summary>
    /// Virgin Islands.
    /// </summary>
    [StringValue("VI")]
    VI,

    /// <summary>
    /// Virginia.
    /// </summary>
    [StringValue("VA")]
    VA,

    /// <summary>
    /// Washington.
    /// </summary>
    [StringValue("WA")]
    WA,

    /// <summary>
    /// West Virgina.
    /// </summary>
    [StringValue("WV")]
    WV,

    /// <summary>
    /// Wisconsin.
    /// </summary>
    [StringValue("WI")]
    WI,

    /// <summary>
    /// Wyoming.
    /// </summary>
    [StringValue("WY")]
    WY,

    /// <summary>
    /// Commonwealth of the Northern Marianas.
    /// </summary>
    [StringValue("MP")]
    MP,

    /// <summary>
    /// Republic of Palau.
    /// </summary>
    [StringValue("PW")]
    PW,

    /// <summary>
    /// Federated States of Micronesia.
    /// </summary>
    [StringValue("FM")]
    FM,

    /// <summary>
    /// Republic of the Marshall Islands.
    /// </summary>
    [StringValue("MH")]
    MH,

    /// <summary>
    /// West N. Atlantic Ocean.
    /// </summary>
    [StringValue("AM")]
    AM,

    /// <summary>
    /// Northwest N. Atlantic Ocean.
    /// </summary>
    [StringValue("AN")]
    AN,

    /// <summary>
    /// Gulf of Mexico.
    /// </summary>
    [StringValue("GM")]
    GM,

    /// <summary>
    /// Lake St. Clair.
    /// </summary>
    [StringValue("LC")]
    LC,

    /// <summary>
    /// Lake Erie.
    /// </summary>
    [StringValue("LE")]
    LE,

    /// <summary>
    /// Lake Huron.
    /// </summary>
    [StringValue("LH")]
    LH,

    /// <summary>
    /// Lake Michigan.
    /// </summary>
    [StringValue("LM")]
    LM,

    /// <summary>
    /// Lake Ontario.
    /// </summary>
    [StringValue("LO")]
    LO,

    /// <summary>
    /// Lake Superior.
    /// </summary>
    [StringValue("LS")]
    LS,

    /// <summary>
    /// Central Pacific Ocean.
    /// </summary>
    [StringValue("PH")]
    PH,

    /// <summary>
    /// N. Pacific Ocean Near Alaska.
    /// </summary>
    [StringValue("PK")]
    PK,

    /// <summary>
    /// Western Pacific Ocean.
    /// </summary>
    [StringValue("PM")]
    PM,

    /// <summary>
    /// S. Central Pacific Ocean.
    /// </summary>
    [StringValue("PS")]
    PS,

    /// <summary>
    /// Eastern N. Pacific Ocean.
    /// </summary>
    [StringValue("PZ")]
    PZ,

    /// <summary>
    /// St. Lawrence River.
    /// </summary>
    [StringValue("SL")]
    SL
}
