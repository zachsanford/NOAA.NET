// <copyright file="WFO.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Extensions;

namespace NOAA.NET.Types;

/// <summary>
/// Weather Field Office enum for the "WFO" input of the Gridpoints Endpoint.
/// </summary>
public enum WFO
{
    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("ABQ")]
    ABQ,

    /// <summary>
    /// Aberdeen, South Dakota type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("ABR")]
    ABR,

    /// <summary>
    /// Anchorage East type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("AER")]
    AER,

    /// <summary>
    /// Anchorage, Alaska type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("AFC")]
    AFC,

    /// <summary>
    /// Fairbanks, Alaska type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("AFG")]
    AFG,

    /// <summary>
    /// Juneau, Alaska type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("AJK")]
    AJK,

    /// <summary>
    /// Wakefield, Virginia type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("AKQ")]
    AKQ,

    /// <summary>
    /// Anchorage West type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("ALU")]
    ALU,

    /// <summary>
    /// Albany, New York type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("ALY")]
    ALY,

    /// <summary>
    /// Amarillo, Texas type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("AMA")]
    AMA,

    /// <summary>
    /// Gaylord, Michigan type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("APX")]
    APX,

    /// <summary>
    /// La Crosse, Wisconsin type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("ARX")]
    ARX,

    /// <summary>
    /// Binghamton, New York type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("BGM")]
    BGM,

    /// <summary>
    /// Bismark, North Dakota type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("BIS")]
    BIS,

    /// <summary>
    /// Birmingham, Alabama type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("BMX")]
    BMX,

    /// <summary>
    /// Boise, Idaho type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("BOI")]
    BOI,

    /// <summary>
    /// Denver/Boulder, Colorado type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("BOU")]
    BOU,

    /// <summary>
    /// Boston/Norton, Massachusetts type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("BOX")]
    BOX,

    /// <summary>
    /// Brownsville/Rio Grande Valley, Texas type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("BRO")]
    BRO,

    /// <summary>
    /// Burlington, Vermont type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("BTV")]
    BTV,

    /// <summary>
    /// Buffalo, New York type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("BUF")]
    BUF,

    /// <summary>
    /// Billings, Montana type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("BYZ")]
    BYZ,

    /// <summary>
    /// Columbia, South Carolina type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("CAE")]
    CAE,

    /// <summary>
    /// Caribou, Maine type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("CAR")]
    CAR,

    /// <summary>
    /// Charleston, South Carolina type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("CHS")]
    CHS,

    /// <summary>
    /// Cleveland, Ohio type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("CLE")]
    CLE,

    /// <summary>
    /// Corpus Christi, Texas type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("CRP")]
    CRP,

    /// <summary>
    /// State College, Pennslyvania type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("CTP")]
    CTP,

    /// <summary>
    /// Cheyenne, Wyoming type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("CYS")]
    CYS,

    /// <summary>
    /// Dodge City, Kansas type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("DDC")]
    DDC,

    /// <summary>
    /// Duluth, Minnesota type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("DLH")]
    DLH,

    /// <summary>
    /// Des Moines, Iowa type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("DMX")]
    DMX,

    /// <summary>
    /// Detroit/Pontiac, Michigan type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("DTX")]
    DTX,

    /// <summary>
    /// Quad Cities, Iowa/Illinois type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("DVN")]
    DVN,

    /// <summary>
    /// Kansas City/Pleasant Hill, Missouri type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("EAX")]
    EAX,

    /// <summary>
    /// Eureka, California type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("EKA")]
    EKA,

    /// <summary>
    /// El Paso, Texas type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("EPZ")]
    EPZ,

    /// <summary>
    /// Austin/San Antonio, Texas type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("EWX")]
    EWX,

    /// <summary>
    /// Peachtree City, Georgia type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("FFC")]
    FFC,

    /// <summary>
    /// Grand Forks, North Dakota type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("FGF")]
    FGF,

    /// <summary>
    /// Flagstaff, Arizona type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("FGZ")]
    FGZ,

    /// <summary>
    /// Sioux Falls, South Dakota type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("FSD")]
    FSD,

    /// <summary>
    /// Fort Worth/Dallas, Texas type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("FWD")]
    FWD,

    /// <summary>
    /// Glasgow, Montana type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("GGW")]
    GGW,

    /// <summary>
    /// Hastings, Nebraska type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("GID")]
    GID,

    /// <summary>
    /// Grand Junction, Colorado type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("GJT")]
    GJT,

    /// <summary>
    /// Goodland, Kansas type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("GLD")]
    GLD,

    /// <summary>
    /// Green Bay, Wisconsin type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("GRB")]
    GRB,

    /// <summary>
    /// Grand Rapids, Michigan type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("GRR")]
    GRR,

    /// <summary>
    /// Greenville-Spartanburg, South Carolina type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("GSP")]
    GSP,

    /// <summary>
    /// Tiyan, Guam type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("GUM")]
    GUM,

    /// <summary>
    /// Gray/Portland, Maine type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("GYX")]
    GYX,

    /// <summary>
    /// Honolulu, Hawaii type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("HFO")]
    HFO,

    /// <summary>
    /// Houston/Galveston, Texas type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("HGX")]
    HGX,

    /// <summary>
    /// San Joaquin Valley, CA type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("HNX")]
    HNX,

    /// <summary>
    /// Huntsville, Alabama type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("HUN")]
    HUN,

    /// <summary>
    /// Wichita, Kansas type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("ICT")]
    ICT,

    /// <summary>
    /// Wilmington, North Carolina type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("ILM")]
    ILM,

    /// <summary>
    /// Wilmington, Ohio type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("ILN")]
    ILN,

    /// <summary>
    /// Central Illinois type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("ILX")]
    ILX,

    /// <summary>
    /// Indianapolis, Indiana type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("IND")]
    IND,

    /// <summary>
    /// Northern Indiana type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("IWX")]
    IWX,

    /// <summary>
    /// Jackson, Mississippi type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("JAN")]
    JAN,

    /// <summary>
    /// Jacksonville, Florida type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("JAX")]
    JAX,

    /// <summary>
    /// Jackson, Kentucky type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("JKL")]
    JKL,

    /// <summary>
    /// Key West, Florida type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("KEY")]
    KEY,

    /// <summary>
    /// North Platte, Nebraska type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("LBF")]
    LBF,

    /// <summary>
    /// Lake Charles, Louisiana type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("LCH")]
    LCH,

    /// <summary>
    /// New Orleans/Baton Rouge, Louisiana type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("LIX")]
    LIX,

    /// <summary>
    /// Elko, Nevada type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("LKN")]
    LKN,

    /// <summary>
    /// Louisville, Kentucky type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("LMK")]
    LMK,

    /// <summary>
    /// Chicago, Illinois type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("LOT")]
    LOT,

    /// <summary>
    /// Los Angeles, California type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("LOX")]
    LOX,

    /// <summary>
    /// St. Louis, Missouri type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("LSX")]
    LSX,

    /// <summary>
    /// Lubbock, Texas type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("LUB")]
    LUB,

    /// <summary>
    /// Baltimore/Washington type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("LWX")]
    LWX,

    /// <summary>
    /// Little Rock, Arkansas type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("LZK")]
    LZK,

    /// <summary>
    /// Midland, Texas type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("MAF")]
    MAF,

    /// <summary>
    /// Memphis, Tennessee type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("MEG")]
    MEG,

    /// <summary>
    /// Miami, Florida type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("MFL")]
    MFL,

    /// <summary>
    /// Medford, Oregon type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("MFR")]
    MFR,

    /// <summary>
    /// Newport/Morehead City, North Carolina type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("MHX")]
    MHX,

    /// <summary>
    /// Milwaukee/Sullivan, Wisconsin type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("MKX")]
    MKX,

    /// <summary>
    /// Melbourne, Florida type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("MLB")]
    MLB,

    /// <summary>
    /// Mobile/Pensacola type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("MOB")]
    MOB,

    /// <summary>
    /// Twin Cities, Minnesota type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("MPX")]
    MPX,

    /// <summary>
    /// Marquette, Michigan type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("MQT")]
    MQT,

    /// <summary>
    /// Morristown, Tennessee type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("MRX")]
    MRX,

    /// <summary>
    /// Missoula, Montana type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("MSO")]
    MSO,

    /// <summary>
    /// San Francisco Bay Area, California type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("MTR")]
    MTR,

    /// <summary>
    /// Omaha/Valley, Nebraska type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("OAX")]
    OAX,

    /// <summary>
    /// Nashville, Tennessee type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("OHX")]
    OHX,

    /// <summary>
    /// New York, New York type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("OKX")]
    OKX,

    /// <summary>
    /// Spokane, WA type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("OTX")]
    OTX,

    /// <summary>
    /// Norman, Oklahoma type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("OUN")]
    OUN,

    /// <summary>
    /// Paducah, Kentucky type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("PAH")]
    PAH,

    /// <summary>
    /// Pittsburgh, Pennslyvania type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("PBZ")]
    PBZ,

    /// <summary>
    /// Pendleton, Oregon type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("PDT")]
    PDT,

    /// <summary>
    /// Philadelphia/Mount Holly, Pennslyvania type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("PHI")]
    PHI,

    /// <summary>
    /// Pocatello, Idaho type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("PIH")]
    PIH,

    /// <summary>
    /// Portland, Oregon type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("PQR")]
    PQR,

    /// <summary>
    /// Phoenix, Arizona type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("PSR")]
    PSR,

    /// <summary>
    /// Pueblo, Colorado type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("PUB")]
    PUB,

    /// <summary>
    /// Raleigh, North Carolina type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("RAH")]
    RAH,

    /// <summary>
    /// Reno, Nevada type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("REV")]
    REV,

    /// <summary>
    /// Riverton, Wyoming type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("RIW")]
    RIW,

    /// <summary>
    /// Charleston, West Virginia type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("RLX")]
    RLX,

    /// <summary>
    /// Blacksburg, Virginia type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("RNK")]
    RNK,

    /// <summary>
    /// Seattle/Tacoma, Washington type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("SEW")]
    SEW,

    /// <summary>
    /// Springfield, Missouri type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("SGF")]
    SGF,

    /// <summary>
    /// San Diego, California type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("SGX")]
    SGX,

    /// <summary>
    /// Shreveport, Louisiana type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("SHV")]
    SHV,

    /// <summary>
    /// San Angelo, Texas type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("SJT")]
    SJT,

    /// <summary>
    /// San Juan, Puerto Rico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("SJU")]
    SJU,

    /// <summary>
    /// Salt Lake City, Utah type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("SLC")]
    SLC,

    /// <summary>
    /// Sacremento, California type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("STO")]
    STO,

    /// <summary>
    /// Tallahassee, Florida type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("TAE")]
    TAE,

    /// <summary>
    /// Tampa Bay Area, Florida type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("TBW")]
    TBW,

    /// <summary>
    /// Great Falls, Montana type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("TFX")]
    TFX,

    /// <summary>
    /// Topeka, Kansas type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("TOP")]
    TOP,

    /// <summary>
    /// Tulsa, Oklahoma type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("TSA")]
    TSA,

    /// <summary>
    /// Tucson, Arizona type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("TWC")]
    TWC,

    /// <summary>
    /// Rapid City, South Dakota type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("UNR")]
    UNR,

    /// <summary>
    /// Las Vegas, Nevada type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("VEF")]
    VEF
}
