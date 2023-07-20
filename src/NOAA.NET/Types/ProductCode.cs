// <copyright file="ProductCode.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Extensions;

namespace NOAA.NET.Types;

/// <summary>
/// Three-letter Product type codes enum.
/// </summary>
public enum ProductCode
{
    /// <summary>
    /// Rawinsonde Data Above 100 Millibars.
    /// </summary>
    [StringValue("ABV")]
    ABV,

    /// <summary>
    /// Alarm/Alert Administrative Msg.
    /// </summary>
    [StringValue("ADA")]
    ADA,

    /// <summary>
    /// Alert Administrative Message.
    /// </summary>
    [StringValue("ADM")]
    ADM,

    /// <summary>
    /// NWS Administrative Message.
    /// </summary>
    [StringValue("ADR")]
    ADR,

    /// <summary>
    /// Generic Space Environment Advisory.
    /// </summary>
    [StringValue("ADV")]
    ADV,

    /// <summary>
    /// Area Forecast Discussion.
    /// </summary>
    [StringValue("AFD")]
    AFD,

    /// <summary>
    /// Area Forecast Matrices.
    /// </summary>
    [StringValue("AFM")]
    AFM,

    /// <summary>
    /// Area Forecast Product.
    /// </summary>
    [StringValue("AFP")]
    AFP,

    /// <summary>
    /// Fire Weather Matrix.
    /// </summary>
    [StringValue("AFW")]
    AFW,

    /// <summary>
    /// Agricultural Forecast.
    /// </summary>
    [StringValue("AGF")]
    AGF,

    /// <summary>
    /// Agricultural Observations.
    /// </summary>
    [StringValue("AGO")]
    AGO,

    /// <summary>
    /// Area Hydrologic Discussion.
    /// </summary>
    [StringValue("AHD")]
    AHD,

    /// <summary>
    /// Space Environment Alert.
    /// </summary>
    [StringValue("ALT")]
    ALT,

    /// <summary>
    /// Air Quality Alert.
    /// </summary>
    [StringValue("AQA")]
    AQA,

    /// <summary>
    /// Air Quality Index Statement.
    /// </summary>
    [StringValue("AQI")]
    AQI,

    /// <summary>
    /// Air Stagnation Advisory.
    /// </summary>
    [StringValue("ASA")]
    ASA,

    /// <summary>
    /// Avalanche Watch.
    /// </summary>
    [StringValue("AVA")]
    AVA,

    /// <summary>
    /// Avalanche Weather Guidance.
    /// </summary>
    [StringValue("AVG")]
    AVG,

    /// <summary>
    /// Avalanche Warning.
    /// </summary>
    [StringValue("AVW")]
    AVW,

    /// <summary>
    /// Area Weather Outlook.
    /// </summary>
    [StringValue("AWO")]
    AWO,

    /// <summary>
    /// Area Weather Summary.
    /// </summary>
    [StringValue("AWS")]
    AWS,

    /// <summary>
    /// Area Weather Update.
    /// </summary>
    [StringValue("AWU")]
    AWU,

    /// <summary>
    /// Airport Weather Warning.
    /// </summary>
    [StringValue("AWW")]
    AWW,

    /// <summary>
    /// Buoy Report.
    /// </summary>
    [StringValue("BOY")]
    BOY,

    /// <summary>
    /// Coast Guard Observations.
    /// </summary>
    [StringValue("BRG")]
    BRG,

    /// <summary>
    /// Hourly Roundup for Weather Radio.
    /// </summary>
    [StringValue("BRT")]
    BRT,

    /// <summary>
    /// Child Abduction Emergency.
    /// </summary>
    [StringValue("CAE")]
    CAE,

    /// <summary>
    /// Common Alerting Protocol.
    /// </summary>
    [StringValue("CAP")]
    CAP,

    /// <summary>
    /// Coded City Forecast.
    /// </summary>
    [StringValue("CCF")]
    CCF,

    /// <summary>
    /// Civil Danger Warning.
    /// </summary>
    [StringValue("CDW")]
    CDW,

    /// <summary>
    /// Civil Emergency Message.
    /// </summary>
    [StringValue("CEM")]
    CEM,

    /// <summary>
    /// WFO Monthly/Daily Climate Data.
    /// </summary>
    [StringValue("CF6")]
    CF6,

    /// <summary>
    /// Convective Forecast Product.
    /// </summary>
    [StringValue("CFP")]
    CFP,

    /// <summary>
    /// Coastal Flood Warnings/Watches/Statements.
    /// </summary>
    [StringValue("CFW")]
    CFW,

    /// <summary>
    /// Coast Guard Surface Report.
    /// </summary>
    [StringValue("CGR")]
    CGR,

    /// <summary>
    /// Computer Hurricane Guidance.
    /// </summary>
    [StringValue("CHG")]
    CHG,

    /// <summary>
    /// Climatological Report (Annual).
    /// </summary>
    [StringValue("CLA")]
    CLA,

    /// <summary>
    /// Climatological Report (Daily).
    /// </summary>
    [StringValue("CLI")]
    CLI,

    /// <summary>
    /// Climatological Report (Monthly).
    /// </summary>
    [StringValue("CLM")]
    CLM,

    /// <summary>
    /// Climatological Report (Quarterly).
    /// </summary>
    [StringValue("CLQ")]
    CLQ,

    /// <summary>
    /// Climatological Report (Seasonal).
    /// </summary>
    [StringValue("CLS")]
    CLS,

    /// <summary>
    /// Climate Report.
    /// </summary>
    [StringValue("CLT")]
    CLT,

    /// <summary>
    /// Coded Climatological Monthly Means.
    /// </summary>
    [StringValue("CMM")]
    CMM,

    /// <summary>
    /// Coded Analysis and Forecasts.
    /// </summary>
    [StringValue("COD")]
    COD,

    /// <summary>
    /// Great Lakes Port Forecast.
    /// </summary>
    [StringValue("CPF")]
    CPF,

    /// <summary>
    /// Routine Space Environment Products.
    /// </summary>
    [StringValue("CUR")]
    CUR,

    /// <summary>
    /// Center (CWSU) Weather Advisory.
    /// </summary>
    [StringValue("CWA")]
    CWA,

    /// <summary>
    /// Coastal Waters Forecast.
    /// </summary>
    [StringValue("CWF")]
    CWF,

    /// <summary>
    /// Center (CWSU) Weather Statement.
    /// </summary>
    [StringValue("CWS")]
    CWS,

    /// <summary>
    /// Routine Space Environment Product (Daily).
    /// </summary>
    [StringValue("DAY")]
    DAY,

    /// <summary>
    /// Daily Dispersion Outlook.
    /// </summary>
    [StringValue("DDO")]
    DDO,

    /// <summary>
    /// Drought Information Statement.
    /// </summary>
    [StringValue("DGT")]
    DGT,

    /// <summary>
    /// Unnumbered Depression / Suspicious Area Advisory.
    /// </summary>
    [StringValue("DSA")]
    DSA,

    /// <summary>
    /// ASOS Daily Summary.
    /// </summary>
    [StringValue("DSM")]
    DSM,

    /// <summary>
    /// Dust Storm Warning.
    /// </summary>
    [StringValue("DSW")]
    DSW,

    /// <summary>
    /// 3 To 5 Day Extended Forecast.
    /// </summary>
    [StringValue("EFP")]
    EFP,

    /// <summary>
    /// Average 6 To 10 Day Weather Outlook (Local).
    /// </summary>
    [StringValue("EOL")]
    EOL,

    /// <summary>
    /// Tsunami Bulletin.
    /// </summary>
    [StringValue("EQI")]
    EQI,

    /// <summary>
    /// Earthquake Report.
    /// </summary>
    [StringValue("EQR")]
    EQR,

    /// <summary>
    /// Earthquake Warning.
    /// </summary>
    [StringValue("EQW")]
    EQW,

    /// <summary>
    /// Flood Potential Outlook.
    /// </summary>
    [StringValue("ESF")]
    ESF,

    /// <summary>
    /// Extended Streamflow Guidance.
    /// </summary>
    [StringValue("ESG")]
    ESG,

    /// <summary>
    /// Extended Streamflow Prediction.
    /// </summary>
    [StringValue("ESP")]
    ESP,

    /// <summary>
    /// Water Supply Outlook.
    /// </summary>
    [StringValue("ESS")]
    ESS,

    /// <summary>
    /// Evacuation Immediate.
    /// </summary>
    [StringValue("EVI")]
    EVI,

    /// <summary>
    /// Extreme Wind Warning.
    /// </summary>
    [StringValue("EWW")]
    EWW,

    /// <summary>
    /// Aviation Area Forecasts (Pacific).
    /// </summary>
    [StringValue("FA0")]
    FA0,

    /// <summary>
    /// Aviation Area Forecasts (Northeast).
    /// </summary>
    [StringValue("FA1")]
    FA1,

    /// <summary>
    /// Aviation Area Forecasts (Southeast).
    /// </summary>
    [StringValue("FA2")]
    FA2,

    /// <summary>
    /// Aviation Area Forecasts (North Central).
    /// </summary>
    [StringValue("FA3")]
    FA3,

    /// <summary>
    /// Aviation Area Forecasts (South Central).
    /// </summary>
    [StringValue("FA4")]
    FA4,

    /// <summary>
    /// Aviation Area Forecasts (Rocky Mountains).
    /// </summary>
    [StringValue("FA5")]
    FA5,

    /// <summary>
    /// Aviation Area Forecasts (West Coast).
    /// </summary>
    [StringValue("FA6")]
    FA6,

    /// <summary>
    /// Aviation Area Forecasts (Juneau, AK).
    /// </summary>
    [StringValue("FA7")]
    FA7,

    /// <summary>
    /// Aviation Area Forecasts (Anchorage, AK).
    /// </summary>
    [StringValue("FA8")]
    FA8,

    /// <summary>
    /// Aviation Area Forecasts (Fairbanks, AK).
    /// </summary>
    [StringValue("FA9")]
    FA9,

    /// <summary>
    /// 24 Hr Fd Winds Aloft Fcst (45,000 and 53,000 Ft).
    /// </summary>
    [StringValue("FD0")]
    FD0,

    /// <summary>
    /// 6 Hour Winds Aloft Forecast.
    /// </summary>
    [StringValue("FD1")]
    FD1,

    /// <summary>
    /// 12 Hour Winds Aloft Forecast.
    /// </summary>
    [StringValue("FD2")]
    FD2,

    /// <summary>
    /// 24 Hour Winds Aloft Forecast.
    /// </summary>
    [StringValue("FD3")]
    FD3,

    /// <summary>
    /// Winds Aloft Forecast.
    /// </summary>
    [StringValue("FD4")]
    FD4,

    /// <summary>
    /// Winds Aloft Forecast.
    /// </summary>
    [StringValue("FD5")]
    FD5,

    /// <summary>
    /// Winds Aloft Forecast.
    /// </summary>
    [StringValue("FD6")]
    FD6,

    /// <summary>
    /// Winds Aloft Forecast.
    /// </summary>
    [StringValue("FD7")]
    FD7,

    /// <summary>
    /// 6 Hour Fd Winds Aloft Fcst (45,000 and 53,000 Ft).
    /// </summary>
    [StringValue("FD8")]
    FD8,

    /// <summary>
    /// 12 Hr Fd Winds Aloft Fcst (45,000 and 53,000 Ft).
    /// </summary>
    [StringValue("FD9")]
    FD9,

    /// <summary>
    /// Fire Danger Indices.
    /// </summary>
    [StringValue("FDI")]
    FDI,

    /// <summary>
    /// Flash Flood Watch.
    /// </summary>
    [StringValue("FFA")]
    FFA,

    /// <summary>
    /// Flash Flood Guidance.
    /// </summary>
    [StringValue("FFG")]
    FFG,

    /// <summary>
    /// Headwater Guidance.
    /// </summary>
    [StringValue("FFH")]
    FFH,

    /// <summary>
    /// Flash Flood Statement.
    /// </summary>
    [StringValue("FFS")]
    FFS,

    /// <summary>
    /// Flash Flood Warning.
    /// </summary>
    [StringValue("FFW")]
    FFW,

    /// <summary>
    /// National Flood Summary.
    /// </summary>
    [StringValue("FLN")]
    FLN,

    /// <summary>
    /// Flood Statement.
    /// </summary>
    [StringValue("FLS")]
    FLS,

    /// <summary>
    /// Flood Warning.
    /// </summary>
    [StringValue("FLW")]
    FLW,

    /// <summary>
    /// Upper Wind Fallout Forecast.
    /// </summary>
    [StringValue("FOF")]
    FOF,

    /// <summary>
    /// Fire Warning.
    /// </summary>
    [StringValue("FRW")]
    FRW,

    /// <summary>
    /// Natl Marine Fisheries Administrative Service Message.
    /// </summary>
    [StringValue("FSH")]
    FSH,

    /// <summary>
    /// WSR-88D Radar Outage Notification / Free Text Message.
    /// </summary>
    [StringValue("FTM")]
    FTM,

    /// <summary>
    /// FOUS Prog Max/Min Temp/Pop Guidance.
    /// </summary>
    [StringValue("FTP")]
    FTP,

    /// <summary>
    /// Fire Weather Administrative Message.
    /// </summary>
    [StringValue("FWA")]
    FWA,

    /// <summary>
    /// Fire Weather Outlook Discussion.
    /// </summary>
    [StringValue("FWD")]
    FWD,

    /// <summary>
    /// Routine Fire Wx Fcst (With/Without 6-10 Day Outlook).
    /// </summary>
    [StringValue("FWF")]
    FWF,

    /// <summary>
    /// Land Management Forecasts.
    /// </summary>
    [StringValue("FWL")]
    FWL,

    /// <summary>
    /// Miscellaneous Fire Weather Product.
    /// </summary>
    [StringValue("FWM")]
    FWM,

    /// <summary>
    /// Fire Weather Notification.
    /// </summary>
    [StringValue("FWN")]
    FWN,

    /// <summary>
    /// Fire Weather Observation.
    /// </summary>
    [StringValue("FWO")]
    FWO,

    /// <summary>
    /// Suppression Forecast.
    /// </summary>
    [StringValue("FWS")]
    FWS,

    /// <summary>
    /// Freezing Level Data (RADAT).
    /// </summary>
    [StringValue("FZL")]
    FZL,

    /// <summary>
    /// Great Lakes Forecast.
    /// </summary>
    [StringValue("GLF")]
    GLF,

    /// <summary>
    /// Great Lakes Storm Summary.
    /// </summary>
    [StringValue("GLS")]
    GLS,

    /// <summary>
    /// GREEN.
    /// </summary>
    [StringValue("GRE")]
    GRE,

    /// <summary>
    /// RFC Derived QPF Data Product.
    /// </summary>
    [StringValue("HD1")]
    HD1,

    /// <summary>
    /// RFC Derived QPF Data Product.
    /// </summary>
    [StringValue("HD2")]
    HD2,

    /// <summary>
    /// RFC Derived QPF Data Product.
    /// </summary>
    [StringValue("HD3")]
    HD3,

    /// <summary>
    /// RFC Derived QPF Data Product.
    /// </summary>
    [StringValue("HD4")]
    HD4,

    /// <summary>
    /// RFC Derived QPF Data Product.
    /// </summary>
    [StringValue("HD7")]
    HD7,

    /// <summary>
    /// RFC Derived QPF Data Product.
    /// </summary>
    [StringValue("HD8")]
    HD8,

    /// <summary>
    /// RFC Derived QPF Data Product.
    /// </summary>
    [StringValue("HD9")]
    HD9,

    /// <summary>
    /// Hurricane Local Statement.
    /// </summary>
    [StringValue("HLS")]
    HLS,

    /// <summary>
    /// National Hydromet Discussion.
    /// </summary>
    [StringValue("HMD")]
    HMD,

    /// <summary>
    /// AHPS XML.
    /// </summary>
    [StringValue("HML")]
    HML,

    /// <summary>
    /// Hazardous Materials Warning.
    /// </summary>
    [StringValue("HMW")]
    HMW,

    /// <summary>
    /// RFC QPF Verification Product.
    /// </summary>
    [StringValue("HP1")]
    HP1,

    /// <summary>
    /// RFC QPF Verification Product.
    /// </summary>
    [StringValue("HP2")]
    HP2,

    /// <summary>
    /// RFC QPF Verification Product.
    /// </summary>
    [StringValue("HP3")]
    HP3,

    /// <summary>
    /// RFC QPF Verification Product.
    /// </summary>
    [StringValue("HP4")]
    HP4,

    /// <summary>
    /// RFC QPF Verification Product.
    /// </summary>
    [StringValue("HP5")]
    HP5,

    /// <summary>
    /// RFC QPF Verification Product.
    /// </summary>
    [StringValue("HP6")]
    HP6,

    /// <summary>
    /// RFC QPF Verification Product.
    /// </summary>
    [StringValue("HP7")]
    HP7,

    /// <summary>
    /// RFC QPF Verification Product.
    /// </summary>
    [StringValue("HP8")]
    HP8,

    /// <summary>
    /// Weather Roundup.
    /// </summary>
    [StringValue("HRR")]
    HRR,

    /// <summary>
    /// High Seas Forecast.
    /// </summary>
    [StringValue("HSF")]
    HSF,

    /// <summary>
    /// Hazardous Weather Outlook.
    /// </summary>
    [StringValue("HWO")]
    HWO,

    /// <summary>
    /// Hourly Weather Roundup.
    /// </summary>
    [StringValue("HWR")]
    HWR,

    /// <summary>
    /// Daily Hydrometeorological Products.
    /// </summary>
    [StringValue("HYD")]
    HYD,

    /// <summary>
    /// Monthly Hydrometeorological Plain Language Product.
    /// </summary>
    [StringValue("HYM")]
    HYM,

    /// <summary>
    /// Ice Forecast.
    /// </summary>
    [StringValue("ICE")]
    ICE,

    /// <summary>
    /// Ice Drift Vectors.
    /// </summary>
    [StringValue("IDM")]
    IDM,

    /// <summary>
    /// ADMINISTR [NOUS51 KWBC].
    /// </summary>
    [StringValue("INI")]
    INI,

    /// <summary>
    /// Ice Observation.
    /// </summary>
    [StringValue("IOB")]
    IOB,

    /// <summary>
    /// Keep Alive Message.
    /// </summary>
    [StringValue("KPA")]
    KPA,

    /// <summary>
    /// Local Area Emergency.
    /// </summary>
    [StringValue("LAE")]
    LAE,

    /// <summary>
    /// Preliminary Local Climatological Data.
    /// </summary>
    [StringValue("LCD")]
    LCD,

    /// <summary>
    /// Local Cooperative Observation.
    /// </summary>
    [StringValue("LCO")]
    LCO,

    /// <summary>
    /// Law Enforcement Warning.
    /// </summary>
    [StringValue("LEW")]
    LEW,

    /// <summary>
    /// Local Forecast.
    /// </summary>
    [StringValue("LFP")]
    LFP,

    /// <summary>
    /// Lake Stages.
    /// </summary>
    [StringValue("LKE")]
    LKE,

    /// <summary>
    /// Low-Level Sounding.
    /// </summary>
    [StringValue("LLS")]
    LLS,

    /// <summary>
    /// Low Temperatures.
    /// </summary>
    [StringValue("LOW")]
    LOW,

    /// <summary>
    /// Local Storm Report.
    /// </summary>
    [StringValue("LSR")]
    LSR,

    /// <summary>
    /// Lightning Data.
    /// </summary>
    [StringValue("LTG")]
    LTG,

    /// <summary>
    /// Rawinsonde Observation Mandatory Levels.
    /// </summary>
    [StringValue("MAN")]
    MAN,

    /// <summary>
    /// Mean Areal Precipitation.
    /// </summary>
    [StringValue("MAP")]
    MAP,

    /// <summary>
    /// Amended Marine Forecast.
    /// </summary>
    [StringValue("MAW")]
    MAW,

    /// <summary>
    /// Marine Forecast Matrix.
    /// </summary>
    [StringValue("MFM")]
    MFM,

    /// <summary>
    /// Marine Interpretation Message.
    /// </summary>
    [StringValue("MIM")]
    MIM,

    /// <summary>
    /// Miscellaneous Local Product.
    /// </summary>
    [StringValue("MIS")]
    MIS,

    /// <summary>
    /// MOB Observations.
    /// </summary>
    [StringValue("MOB")]
    MOB,

    /// <summary>
    /// Routine Space Environment Product Issued Monthly.
    /// </summary>
    [StringValue("MON")]
    MON,

    /// <summary>
    /// Techniques Development Laboratory Marine Product.
    /// </summary>
    [StringValue("MRP")]
    MRP,

    /// <summary>
    /// ASOS Monthly Summary Message.
    /// </summary>
    [StringValue("MSM")]
    MSM,

    /// <summary>
    /// METAR Formatted Surface Weather Observation.
    /// </summary>
    [StringValue("MTR")]
    MTR,

    /// <summary>
    /// METAR Test Message.
    /// </summary>
    [StringValue("MTT")]
    MTT,

    /// <summary>
    /// Marine Verification Coded Message.
    /// </summary>
    [StringValue("MVF")]
    MVF,

    /// <summary>
    /// Marine Weather Statement.
    /// </summary>
    [StringValue("MWS")]
    MWS,

    /// <summary>
    /// Marine Weather Message.
    /// </summary>
    [StringValue("MWW")]
    MWW,

    /// <summary>
    /// Weather Reconnaisance Flights.
    /// </summary>
    [StringValue("NOU")]
    NOU,

    /// <summary>
    /// Short Term Forecast.
    /// </summary>
    [StringValue("NOW")]
    NOW,

    /// <summary>
    /// Data Mgt Message.
    /// </summary>
    [StringValue("NOX")]
    NOX,

    /// <summary>
    /// Non-Precipitation Warnings / Watches / Advisories.
    /// </summary>
    [StringValue("NPW")]
    NPW,

    /// <summary>
    /// Nearshore Marine Forecast.
    /// </summary>
    [StringValue("NSH")]
    NSH,

    /// <summary>
    /// Nuclear Power Plant Warning.
    /// </summary>
    [StringValue("NUW")]
    NUW,

    /// <summary>
    /// NOAA Weather Radio Forecast.
    /// </summary>
    [StringValue("NWR")]
    NWR,

    /// <summary>
    /// Other Aviation Products.
    /// </summary>
    [StringValue("OAV")]
    OAV,

    /// <summary>
    /// Observations.
    /// </summary>
    [StringValue("OBS")]
    OBS,

    /// <summary>
    /// Offshore Aviation Area Forecast.
    /// </summary>
    [StringValue("OFA")]
    OFA,

    /// <summary>
    /// Offshore Forecast.
    /// </summary>
    [StringValue("OFF")]
    OFF,

    /// <summary>
    /// Other Marine Products.
    /// </summary>
    [StringValue("OMR")]
    OMR,

    /// <summary>
    /// Other Public Products.
    /// </summary>
    [StringValue("OPU")]
    OPU,

    /// <summary>
    /// Other Surface Observations.
    /// </summary>
    [StringValue("OSO")]
    OSO,

    /// <summary>
    /// Ocean Surface Winds.
    /// </summary>
    [StringValue("OSW")]
    OSW,

    /// <summary>
    /// Other Upper Air Data.
    /// </summary>
    [StringValue("OUA")]
    OUA,

    /// <summary>
    /// Zone Forecast.
    /// </summary>
    [StringValue("OZF")]
    OZF,

    /// <summary>
    /// Point Forecast Matrices.
    /// </summary>
    [StringValue("PFM")]
    PFM,

    /// <summary>
    /// Fire Weather Point Forecast Matrices.
    /// </summary>
    [StringValue("PFW")]
    PFW,

    /// <summary>
    /// Plain Language Ship Report.
    /// </summary>
    [StringValue("PLS")]
    PLS,

    /// <summary>
    /// Prognostic Meteorological Discussion.
    /// </summary>
    [StringValue("PMD")]
    PMD,

    /// <summary>
    /// Public Information Statement.
    /// </summary>
    [StringValue("PNS")]
    PNS,

    /// <summary>
    /// Probability of Exceed.
    /// </summary>
    [StringValue("POE")]
    POE,

    /// <summary>
    /// Heat Index Forecast Tables.
    /// </summary>
    [StringValue("PRB")]
    PRB,

    /// <summary>
    /// State Pilot Report Collective.
    /// </summary>
    [StringValue("PRC")]
    PRC,

    /// <summary>
    /// Preliminary Forecasts.
    /// </summary>
    [StringValue("PRE")]
    PRE,

    /// <summary>
    /// Post Storm Hurricane Report.
    /// </summary>
    [StringValue("PSH")]
    PSH,

    /// <summary>
    /// Probabilistic Outlook Points.
    /// </summary>
    [StringValue("PTS")]
    PTS,

    /// <summary>
    /// Public Severe Weather Outlook.
    /// </summary>
    [StringValue("PWO")]
    PWO,

    /// <summary>
    /// Tropical Cyclone Probabilities.
    /// </summary>
    [StringValue("PWS")]
    PWS,

    /// <summary>
    /// Quantitative Precipitation Forecast.
    /// </summary>
    [StringValue("QPF")]
    QPF,

    /// <summary>
    /// Quantitative Precipitation Statement.
    /// </summary>
    [StringValue("QPS")]
    QPS,

    /// <summary>
    /// Revised Digital Forecast.
    /// </summary>
    [StringValue("RDF")]
    RDF,

    /// <summary>
    /// Recreational Report.
    /// </summary>
    [StringValue("REC")]
    REC,

    /// <summary>
    /// Record Report.
    /// </summary>
    [StringValue("RER")]
    RER,

    /// <summary>
    /// EAS Activation Request.
    /// </summary>
    [StringValue("RET")]
    RET,

    /// <summary>
    /// Rangeland Fire Danger Forecast.
    /// </summary>
    [StringValue("RFD")]
    RFD,

    /// <summary>
    /// RFI Observation.
    /// </summary>
    [StringValue("RFI")]
    RFI,

    /// <summary>
    /// Route Forecast.
    /// </summary>
    [StringValue("RFR")]
    RFR,

    /// <summary>
    /// Red Flag Warning.
    /// </summary>
    [StringValue("RFW")]
    RFW,

    /// <summary>
    /// Radiological Hazard Warning.
    /// </summary>
    [StringValue("RHW")]
    RHW,

    /// <summary>
    /// Rain Information Statement.
    /// </summary>
    [StringValue("RNS")]
    RNS,

    /// <summary>
    /// Hydro-Met Data Report Part 1.
    /// </summary>
    [StringValue("RR1")]
    RR1,

    /// <summary>
    /// Hydro-Met Data Report Part 2.
    /// </summary>
    [StringValue("RR2")]
    RR2,

    /// <summary>
    /// Hydro-Met Data Report Part 3.
    /// </summary>
    [StringValue("RR3")]
    RR3,

    /// <summary>
    /// Hydro-Met Data Report Part 4.
    /// </summary>
    [StringValue("RR4")]
    RR4,

    /// <summary>
    /// Hydro-Met Data Report Part 5.
    /// </summary>
    [StringValue("RR5")]
    RR5,

    /// <summary>
    /// Hydro-Met Data Report Part 6.
    /// </summary>
    [StringValue("RR6")]
    RR6,

    /// <summary>
    /// Hydro-Met Data Report Part 7.
    /// </summary>
    [StringValue("RR7")]
    RR7,

    /// <summary>
    /// Hydro-Met Data Report Part 8.
    /// </summary>
    [StringValue("RR8")]
    RR8,

    /// <summary>
    /// Hydro-Met Data Report Part 9.
    /// </summary>
    [StringValue("RR9")]
    RR9,

    /// <summary>
    /// Automated Hydrologic Observation Sta Report (AHOS).
    /// </summary>
    [StringValue("RRA")]
    RRA,

    /// <summary>
    /// Miscellaneous Hydrologic Data.
    /// </summary>
    [StringValue("RRM")]
    RRM,

    /// <summary>
    /// HADS Data.
    /// </summary>
    [StringValue("RRS")]
    RRS,

    /// <summary>
    /// ASOS SHEF Hourly Routine Test Message.
    /// </summary>
    [StringValue("RRY")]
    RRY,

    /// <summary>
    /// Daily Snotel Data.
    /// </summary>
    [StringValue("RSD")]
    RSD,

    /// <summary>
    /// Monthly Snotel Data.
    /// </summary>
    [StringValue("RSM")]
    RSM,

    /// <summary>
    /// Regional Max/Min Temp and Precipitation Table.
    /// </summary>
    [StringValue("RTP")]
    RTP,

    /// <summary>
    /// River Summary.
    /// </summary>
    [StringValue("RVA")]
    RVA,

    /// <summary>
    /// Daily River Forecasts.
    /// </summary>
    [StringValue("RVD")]
    RVD,

    /// <summary>
    /// River Forecast.
    /// </summary>
    [StringValue("RVF")]
    RVF,

    /// <summary>
    /// River Ice Statement.
    /// </summary>
    [StringValue("RVI")]
    RVI,

    /// <summary>
    /// Miscellaneous River Product.
    /// </summary>
    [StringValue("RVM")]
    RVM,

    /// <summary>
    /// River Recreation Statement.
    /// </summary>
    [StringValue("RVR")]
    RVR,

    /// <summary>
    /// River Statement.
    /// </summary>
    [StringValue("RVS")]
    RVS,

    /// <summary>
    /// Regional Weather Roundup.
    /// </summary>
    [StringValue("RWR")]
    RWR,

    /// <summary>
    /// Regional Weather Summary.
    /// </summary>
    [StringValue("RWS")]
    RWS,

    /// <summary>
    /// Special Avalanche Bulletin.
    /// </summary>
    [StringValue("SAB")]
    SAB,

    /// <summary>
    /// Speci Agri Wx Fcst / Advisory / Flying Farmer Fcst Outlook.
    /// </summary>
    [StringValue("SAF")]
    SAF,

    /// <summary>
    /// Snow Avalanche Guidance.
    /// </summary>
    [StringValue("SAG")]
    SAG,

    /// <summary>
    /// APT Prediction.
    /// </summary>
    [StringValue("SAT")]
    SAT,

    /// <summary>
    /// Prelim Notice of Watch &amp; Cancellation Msg (Aviation).
    /// </summary>
    [StringValue("SAW")]
    SAW,

    /// <summary>
    /// Storm Summary.
    /// </summary>
    [StringValue("SCC")]
    SCC,

    /// <summary>
    /// Supplementary Climatological Data (ASOS).
    /// </summary>
    [StringValue("SCD")]
    SCD,

    /// <summary>
    /// Soil Climate Analysis Network Data.
    /// </summary>
    [StringValue("SCN")]
    SCN,

    /// <summary>
    /// Satellite Cloud Product.
    /// </summary>
    [StringValue("SCP")]
    SCP,

    /// <summary>
    /// Selected Cities Summary.
    /// </summary>
    [StringValue("SCS")]
    SCS,

    /// <summary>
    /// Supplementary Data Observation (ASOS).
    /// </summary>
    [StringValue("SDO")]
    SDO,

    /// <summary>
    /// Special Dispersion Statement.
    /// </summary>
    [StringValue("SDS")]
    SDS,

    /// <summary>
    /// Severe Local Storm Watch and Watch Cancellation Msg.
    /// </summary>
    [StringValue("SEL")]
    SEL,

    /// <summary>
    /// SPC Watch Point Information Message.
    /// </summary>
    [StringValue("SEV")]
    SEV,

    /// <summary>
    /// State Forecast.
    /// </summary>
    [StringValue("SFP")]
    SFP,

    /// <summary>
    /// Tabular State Forecast.
    /// </summary>
    [StringValue("SFT")]
    SFT,

    /// <summary>
    /// Rawinsonde Observation Significant Levels.
    /// </summary>
    [StringValue("SGL")]
    SGL,

    /// <summary>
    /// Surface Ship Report at Synoptic Time.
    /// </summary>
    [StringValue("SHP")]
    SHP,

    /// <summary>
    /// International Sigmet / Convective Sigmet.
    /// </summary>
    [StringValue("SIG")]
    SIG,

    /// <summary>
    /// Satellite Interpretation Message.
    /// </summary>
    [StringValue("SIM")]
    SIM,

    /// <summary>
    /// Severe Local Storm Watch and Areal Outline.
    /// </summary>
    [StringValue("SLS")]
    SLS,

    /// <summary>
    /// Smoke Management Weather Forecast.
    /// </summary>
    [StringValue("SMF")]
    SMF,

    /// <summary>
    /// Special Marine Warning.
    /// </summary>
    [StringValue("SMW")]
    SMW,

    /// <summary>
    /// SOO Product.
    /// </summary>
    [StringValue("SOO")]
    SOO,

    /// <summary>
    /// Satellite Precipitation Estimates (TXUS20 KWBC).
    /// </summary>
    [StringValue("SPE")]
    SPE,

    /// <summary>
    /// Storm Strike Probability Bulletin (TPC).
    /// </summary>
    [StringValue("SPF")]
    SPF,

    /// <summary>
    /// Special Weather Statement.
    /// </summary>
    [StringValue("SPS")]
    SPS,

    /// <summary>
    /// Shelter in Place Warning.
    /// </summary>
    [StringValue("SPW")]
    SPW,

    /// <summary>
    /// Snow Squall Warning.
    /// </summary>
    [StringValue("SQW")]
    SQW,

    /// <summary>
    /// Surf Discussion.
    /// </summary>
    [StringValue("SRD")]
    SRD,

    /// <summary>
    /// Surf Forecast.
    /// </summary>
    [StringValue("SRF")]
    SRF,

    /// <summary>
    /// Soaring Guidance.
    /// </summary>
    [StringValue("SRG")]
    SRG,

    /// <summary>
    /// Main Synoptic Hour Surface Observation.
    /// </summary>
    [StringValue("SSM")]
    SSM,

    /// <summary>
    /// Network and Severe Weather Statistical Summaries.
    /// </summary>
    [StringValue("STA")]
    STA,

    /// <summary>
    /// Satellite Tropical Disturbance Summary.
    /// </summary>
    [StringValue("STD")]
    STD,

    /// <summary>
    /// Road Condition Reports (State Agencies).
    /// </summary>
    [StringValue("STO")]
    STO,

    /// <summary>
    /// State Max/Min Temperature and Precipitation Table.
    /// </summary>
    [StringValue("STP")]
    STP,

    /// <summary>
    /// Spot Forecast Request.
    /// </summary>
    [StringValue("STQ")]
    STQ,

    /// <summary>
    /// Space Weather Message.
    /// </summary>
    [StringValue("SUM")]
    SUM,

    /// <summary>
    /// Severe Thunderstorm Warning.
    /// </summary>
    [StringValue("SVR")]
    SVR,

    /// <summary>
    /// Severe Weather Statement.
    /// </summary>
    [StringValue("SVS")]
    SVS,

    /// <summary>
    /// Severe Storm Outlook Narrative (AC).
    /// </summary>
    [StringValue("SWO")]
    SWO,

    /// <summary>
    /// State Weather Summary.
    /// </summary>
    [StringValue("SWS")]
    SWS,

    /// <summary>
    /// Regional Weather Synopsis.
    /// </summary>
    [StringValue("SYN")]
    SYN,

    /// <summary>
    /// Terminal Aerodrome Forecast.
    /// </summary>
    [StringValue("TAF")]
    TAF,

    /// <summary>
    /// Terminal Alerting Products.
    /// </summary>
    [StringValue("TAP")]
    TAP,

    /// <summary>
    /// Travelers Forecast Table.
    /// </summary>
    [StringValue("TAV")]
    TAV,

    /// <summary>
    /// Aviation Tropical Cyclone Advisory.
    /// </summary>
    [StringValue("TCA")]
    TCA,

    /// <summary>
    /// Tropical Cyclone Discussion.
    /// </summary>
    [StringValue("TCD")]
    TCD,

    /// <summary>
    /// Tropical Cyclone Position Estimate.
    /// </summary>
    [StringValue("TCE")]
    TCE,

    /// <summary>
    /// Marine/Aviation Tropical Cyclone Advisory.
    /// </summary>
    [StringValue("TCM")]
    TCM,

    /// <summary>
    /// Public Tropical Cyclone Advisory.
    /// </summary>
    [StringValue("TCP")]
    TCP,

    /// <summary>
    /// Satellite Tropical Cyclone Summary.
    /// </summary>
    [StringValue("TCS")]
    TCS,

    /// <summary>
    /// Tropical Cyclone Update.
    /// </summary>
    [StringValue("TCU")]
    TCU,

    /// <summary>
    /// Tropical Cyclone Watch/Warning Break Points.
    /// </summary>
    [StringValue("TCV")]
    TCV,

    /// <summary>
    /// Tsunami Bulletin.
    /// </summary>
    [StringValue("TIB")]
    TIB,

    /// <summary>
    /// Tide Report.
    /// </summary>
    [StringValue("TID")]
    TID,

    /// <summary>
    /// Tsunami Tide/Seismic Message Acknowledgement.
    /// </summary>
    [StringValue("TMA")]
    TMA,

    /// <summary>
    /// 911 Telephone Outage Emergency.
    /// </summary>
    [StringValue("TOE")]
    TOE,

    /// <summary>
    /// Tornado Warning.
    /// </summary>
    [StringValue("TOR")]
    TOR,

    /// <summary>
    /// Temperature Precipitation Table (Natl and Intnl).
    /// </summary>
    [StringValue("TPT")]
    TPT,

    /// <summary>
    /// Tsunami Watch/Warning.
    /// </summary>
    [StringValue("TSU")]
    TSU,

    /// <summary>
    /// Weather Bulletin.
    /// </summary>
    [StringValue("TUV")]
    TUV,

    /// <summary>
    /// Travelers Forecast.
    /// </summary>
    [StringValue("TVL")]
    TVL,

    /// <summary>
    /// Transcribed Weather Broadcast.
    /// </summary>
    [StringValue("TWB")]
    TWB,

    /// <summary>
    /// Tropical Weather Discussion.
    /// </summary>
    [StringValue("TWD")]
    TWD,

    /// <summary>
    /// Tropical Weather Outlook and Summary.
    /// </summary>
    [StringValue("TWO")]
    TWO,

    /// <summary>
    /// Tropical Weather Summary.
    /// </summary>
    [StringValue("TWS")]
    TWS,

    /// <summary>
    /// Aircraft Reconnaissance.
    /// </summary>
    [StringValue("URN")]
    URN,

    /// <summary>
    /// Ultraviolet Index.
    /// </summary>
    [StringValue("UVI")]
    UVI,

    /// <summary>
    /// Volcanic Activity Advisory.
    /// </summary>
    [StringValue("VAA")]
    VAA,

    /// <summary>
    /// Forecast Verification Statistics.
    /// </summary>
    [StringValue("VER")]
    VER,

    /// <summary>
    /// Terminal Aerodrome Forecast (TAF) Verification.
    /// </summary>
    [StringValue("VFT")]
    VFT,

    /// <summary>
    /// Volcano Warning.
    /// </summary>
    [StringValue("VOW")]
    VOW,

    /// <summary>
    /// Airmet (Pacific).
    /// </summary>
    [StringValue("WA0")]
    WA0,

    /// <summary>
    /// Airmet (Northeast).
    /// </summary>
    [StringValue("WA1")]
    WA1,

    /// <summary>
    /// Airmet (Southeast).
    /// </summary>
    [StringValue("WA2")]
    WA2,

    /// <summary>
    /// Airmet (North Central).
    /// </summary>
    [StringValue("WA3")]
    WA3,

    /// <summary>
    /// Airmet (South Central).
    /// </summary>
    [StringValue("WA4")]
    WA4,

    /// <summary>
    /// Airmet (Rocky Mountains).
    /// </summary>
    [StringValue("WA5")]
    WA5,

    /// <summary>
    /// Airmet (West Coast).
    /// </summary>
    [StringValue("WA6")]
    WA6,

    /// <summary>
    /// Airmet (Juneau, AK).
    /// </summary>
    [StringValue("WA7")]
    WA7,

    /// <summary>
    /// Airmet (Anchorage, AK).
    /// </summary>
    [StringValue("WA8")]
    WA8,

    /// <summary>
    /// Airmet (Fairbanks, AK).
    /// </summary>
    [StringValue("WA9")]
    WA9,

    /// <summary>
    /// Space Environment Warning.
    /// </summary>
    [StringValue("WAR")]
    WAR,

    /// <summary>
    /// Space Environment Watch.
    /// </summary>
    [StringValue("WAT")]
    WAT,

    /// <summary>
    /// Weather Watch Clearance Notification.
    /// </summary>
    [StringValue("WCN")]
    WCN,

    /// <summary>
    /// Weekly Weather and Crop Report.
    /// </summary>
    [StringValue("WCR")]
    WCR,

    /// <summary>
    /// Weekly Data for Agriculture.
    /// </summary>
    [StringValue("WDA")]
    WDA,

    /// <summary>
    /// Warning Decision Update.
    /// </summary>
    [StringValue("WDU")]
    WDU,

    /// <summary>
    /// Routine Space Environment Product Issued Weekly.
    /// </summary>
    [StringValue("WEK")]
    WEK,

    /// <summary>
    /// Tornado/Severe Thunderstorm Watch.
    /// </summary>
    [StringValue("WOU")]
    WOU,

    /// <summary>
    /// Sigmet (Northeast).
    /// </summary>
    [StringValue("WS1")]
    WS1,

    /// <summary>
    /// Sigmet (Southeast).
    /// </summary>
    [StringValue("WS2")]
    WS2,

    /// <summary>
    /// Sigmet (North Central).
    /// </summary>
    [StringValue("WS3")]
    WS3,

    /// <summary>
    /// Sigmet (South Central).
    /// </summary>
    [StringValue("WS4")]
    WS4,

    /// <summary>
    /// Sigmet (Rocky Mountains).
    /// </summary>
    [StringValue("WS5")]
    WS5,

    /// <summary>
    /// Sigmet (West Coast).
    /// </summary>
    [StringValue("WS6")]
    WS6,

    /// <summary>
    /// Tropical Cyclone Sigmet.
    /// </summary>
    [StringValue("WST")]
    WST,

    /// <summary>
    /// Volcanic Activity Sigmet.
    /// </summary>
    [StringValue("WSV")]
    WSV,

    /// <summary>
    /// Winter Weather Warnings / Watches / Advisories.
    /// </summary>
    [StringValue("WSW")]
    WSW,

    /// <summary>
    /// Watch Status Report.
    /// </summary>
    [StringValue("WWA")]
    WWA,

    /// <summary>
    /// Severe Thunderstorm / Tornado Watch Probabilities.
    /// </summary>
    [StringValue("WWP")]
    WWP,

    /// <summary>
    /// Zone Forecast Product.
    /// </summary>
    [StringValue("ZFP")]
    ZFP
}
