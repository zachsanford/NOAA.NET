// <copyright file="WFO.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Extensions;

namespace NOAA.NET.Gridpoints.Types;

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
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("DMX")]
    DMX,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("DTX")]
    DTX,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("DVN")]
    DVN,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("EAX")]
    EAX,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("EKA")]
    EKA,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("EPZ")]
    EPZ,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("EWX")]
    EWX,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("FFC")]
    FFC,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("FGF")]
    FGF,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("FGZ")]
    FGZ,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("FSD")]
    FSD,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("FWD")]
    FWD,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("GGW")]
    GGW,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("GID")]
    GID,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("GJT")]
    GJT,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("GLD")]
    GLD,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("GRB")]
    GRB,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("GRR")]
    GRR,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("GSP")]
    GSP,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("GUM")]
    GUM,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("GYX")]
    GYX,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("HFO")]
    HFO,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("HGX")]
    HGX,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("HNX")]
    HNX,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("HPA")]
    HPA,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("HUN")]
    HUN,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("ICT")]
    ICT,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("ILM")]
    ILM,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("ILN")]
    ILN,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("ILX")]
    ILX,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("IND")]
    IND,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("IWX")]
    IWX,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("JAN")]
    JAN,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("JAX")]
    JAX,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("JKL")]
    JKL,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("KEY")]
    KEY,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("LBF")]
    LBF,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("LCH")]
    LCH,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("LIX")]
    LIX,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("LKN")]
    LKN,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("LMK")]
    LMK,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("LOT")]
    LOT,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("LOX")]
    LOX,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("LSX")]
    LSX,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("LUB")]
    LUB,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("LWX")]
    LWX,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("LZK")]
    LZK,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("MAF")]
    MAF,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("MEG")]
    MEG,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("MFL")]
    MFL,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("MFR")]
    MFR,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("MHX")]
    MHX,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("MKX")]
    MKX,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("MLB")]
    MLB,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("MOB")]
    MOB,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("MPX")]
    MPX,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("MQT")]
    MQT,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("MRX")]
    MRX,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("MSO")]
    MSO,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("MTR")]
    MTR,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("NH1")]
    NH1,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("NH2")]
    NH2,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("OAX")]
    OAX,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("OHX")]
    OHX,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("OKX")]
    OKX,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("ONA")]
    ONA,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("ONP")]
    ONP,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("OTX")]
    OTX,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("OUN")]
    OUN,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("PAH")]
    PAH,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("PBZ")]
    PBZ,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("PDT")]
    PDT,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("PHI")]
    PHI,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("PIH")]
    PIH,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("PPG")]
    PPG,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("PQR")]
    PQR,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("PSR")]
    PSR,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("PUB")]
    PUB,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("RAH")]
    RAH,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("REV")]
    REV,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("RIW")]
    RIW,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("RLX")]
    RLX,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("RNK")]
    RNK,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("SEW")]
    SEW,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("SGF")]
    SGF,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("SGX")]
    SGX,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("SHV")]
    SHV,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("SJT")]
    SJT,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("SJU")]
    SJU,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("SLC")]
    SLC,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("STO")]
    STO,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("STU")]
    STU,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("TAE")]
    TAE,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("TBW")]
    TBW,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("TFX")]
    TFX,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("TOP")]
    TOP,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("TSA")]
    TSA,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("TWC")]
    TWC,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("UNR")]
    UNR,

    /// <summary>
    /// Albuquerque, New Mexico type for the "WFO" value of the Gridpoints Endpoint.
    /// </summary>
    [StringValue("VEF")]
    VEF
}
