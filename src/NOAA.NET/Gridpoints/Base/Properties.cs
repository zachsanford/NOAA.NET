// <copyright file="Properties.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;

namespace NOAA.NET.Gridpoints.Base;

/// <summary>
/// A representation of a Properties object.
/// </summary>
public class Properties
{
    /// <summary>
    /// Gets or sets the Id property.
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the Type property.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the Update Time property.
    /// </summary>
    public DateTime? UpdateTime { get; set; }

    /// <summary>
    /// Gets or sets the Valid Times property.
    /// </summary>
    public string? ValidTimes { get; set; }

    /// <summary>
    /// Gets or sets the Elevation property.
    /// </summary>
    public Elevation? Elevation { get; set; }

    /// <summary>
    /// Gets or sets the Forecast Office property.
    /// </summary>
    public string? ForecastOffice { get; set; }

    /// <summary>
    /// Gets or sets the Grid Id property.
    /// </summary>
    public string? GridId { get; set; }

    /// <summary>
    /// Gets or sets the Grid X property.
    /// </summary>
    public string? GridX { get; set; }

    /// <summary>
    /// Gets or sets the Grid Y property.
    /// </summary>
    public string? GridY { get; set; }

    /// <summary>
    /// Gets or sets the Temperature property.
    /// </summary>
    public Temperature? Temperature { get; set; }

    /// <summary>
    /// Gets or sets the Dewpoint property.
    /// </summary>
    public Dewpoint? Dewpoint { get; set; }

    /// <summary>
    /// Gets or sets the Max Temperature property.
    /// </summary>
    public MaxTemperature? MaxTemperature { get; set; }

    /// <summary>
    /// Gets or sets the Min Temperature property.
    /// </summary>
    public MinTemperature? MinTemperature { get; set; }

    /// <summary>
    /// Gets or sets the Relative Humidity property.
    /// </summary>
    public RelativeHumidity? RelativeHumidity { get; set; }

    /// <summary>
    /// Gets or sets the Apparent Temperature property.
    /// </summary>
    public ApparentTemperature? ApparentTemperature { get; set; }

    /// <summary>
    /// Gets or sets the Wet Bulb Globe Temperature property.
    /// </summary>
    public WetBulbGlobeTemperature? WetBulbGlobeTemperature { get; set; }

    /// <summary>
    /// Gets or sets the Heat Index property.
    /// </summary>
    public HeatIndex? HeatIndex { get; set; }

    /// <summary>
    /// Gets or sets the Wind Chill property.
    /// </summary>
    public WindChill? WindChill { get; set; }

    /// <summary>
    /// Gets or sets the Sky Cover property.
    /// </summary>
    public SkyCover? SkyCover { get; set; }

    /// <summary>
    /// Gets or sets the Wind Direction property.
    /// </summary>
    public WindDirection? WindDirection { get; set; }

    /// <summary>
    /// Gets or sets the Wind Speed property.
    /// </summary>
    public WindSpeed? WindSpeed { get; set; }

    /// <summary>
    /// Gets or sets the Wind Gust property.
    /// </summary>
    public WindGust? WindGust { get; set; }

    /// <summary>
    /// Gets or sets the Weather property.
    /// </summary>
    public Weather? Weather { get; set; }

    /// <summary>
    /// Gets or sets the Hazards property.
    /// </summary>
    public Hazards? Hazards { get; set; }

    /// <summary>
    /// Gets or sets the Probability of Precipitation property.
    /// </summary>
    public ProbabilityOfPrecipitation? ProbabilityOfPrecipitation { get; set; }

    /// <summary>
    /// Gets or sets the Quantitative Precipitation property.
    /// </summary>
    public QuantitativePrecipitation? QuantitativePrecipitation { get; set; }

    /// <summary>
    /// Gets or sets the Ice Accumulation property.
    /// </summary>
    public IceAccumulation? IceAccumulation { get; set; }

    /// <summary>
    /// Gets or sets the Snowfall Amount property.
    /// </summary>
    public SnowfallAmount? SnowfallAmount { get; set; }

    /// <summary>
    /// Gets or sets the Snow Level property.
    /// </summary>
    public SnowLevel? SnowLevel { get; set; }

    /// <summary>
    /// Gets or sets the Ceiling Height property.
    /// </summary>
    public CeilingHeight? CeilingHeight { get; set; }

    /// <summary>
    /// Gets or sets the Visibility property.
    /// </summary>
    public Visibility? Visibility { get; set; }

    /// <summary>
    /// Gets or sets the Transport Wind Speed property.
    /// </summary>
    public TransportWindSpeed? TransportWindSpeed { get; set; }

    /// <summary>
    /// Gets or sets the Transport Wind Direction property.
    /// </summary>
    public TransportWindDirection? TransportWindDirection { get; set; }

    /// <summary>
    /// Gets or sets the Mixing Height property.
    /// </summary>
    public MixingHeight? MixingHeight { get; set; }

    /// <summary>
    /// Gets or sets the Haines Index property.
    /// </summary>
    public HainesIndex? HainesIndex { get; set; }

    /// <summary>
    /// Gets or sets the Lightning Activity Level property.
    /// </summary>
    public LightningActivityLevel? LightningActivityLevel { get; set; }

    /// <summary>
    /// Gets or sets the Twenty Foot Wind Speed property.
    /// </summary>
    public TwentyFootWindSpeed? TwentyFootWindSpeed { get; set; }

    /// <summary>
    /// Gets or sets the Twenty Foot Wind Direction property.
    /// </summary>
    public TwentyFootWindDirection? TwentyFootWindDirection { get; set; }

    /// <summary>
    /// Gets or sets the Wave Height property.
    /// </summary>
    public WaveHeight? WaveHeight { get; set; }

    /// <summary>
    /// Gets or sets the Wave Period property.
    /// </summary>
    public WavePeriod? WavePeriod { get; set; }

    /// <summary>
    /// Gets or sets the Wave Direction property.
    /// </summary>
    public WaveDirection? WaveDirection { get; set; }

    /// <summary>
    /// Gets or sets the Primary Swell Height property.
    /// </summary>
    public PrimarySwellHeight? PrimarySwellHeight { get; set; }

    /// <summary>
    /// Gets or sets the Primary Swell Direction property.
    /// </summary>
    public PrimarySwellDirection? PrimarySwellDirection { get; set; }

    /// <summary>
    /// Gets or sets the Secondary Swell Height property.
    /// </summary>
    public SecondarySwellHeight? SecondarySwellHeight { get; set; }

    /// <summary>
    /// Gets or sets the Secondary Swell Direction property.
    /// </summary>
    public SecondarySwellDirection? SecondarySwellDirection { get; set; }

    /// <summary>
    /// Gets or sets the Wave Period 2 property.
    /// </summary>
    public WavePeriod2? WavePeriod2 { get; set; }

    /// <summary>
    /// Gets or sets the Wind Wave Height property.
    /// </summary>
    public WindWaveHeight? WindWaveHeight { get; set; }

    /// <summary>
    /// Gets or sets the Dispersion Index property.
    /// </summary>
    public DispersionIndex? DispersionIndex { get; set; }

    /// <summary>
    /// Gets or sets the Pressure property.
    /// </summary>
    public Pressure? Pressure { get; set; }

    /// <summary>
    /// Gets or sets the Probability of Tropical Storm Winds property.
    /// </summary>
    public ProbabilityOfTropicalStormWinds? ProbabilityOfTropicalStormWinds { get; set; }

    /// <summary>
    /// Gets or sets the Probability of Hurricane Winds property.
    /// </summary>
    public ProbabilityOfHurricaneWinds? ProbabilityOfHurricaneWinds { get; set; }

    /// <summary>
    /// Gets or sets the Potential of 15 MPH Winds property.
    /// </summary>
    public PotentialOf15MphWinds? PotentialOf15MphWinds { get; set; }

    /// <summary>
    /// Gets or sets the Potential of 25 MPH Winds property.
    /// </summary>
    public PotentialOf25MphWinds? PotentialOf25MphWinds { get; set; }

    /// <summary>
    /// Gets or sets the Potential of 35 MPH Winds property.
    /// </summary>
    public PotentialOf35MphWinds? PotentialOf35MphWinds { get; set; }

    /// <summary>
    /// Gets or sets the Potential of 45 MPH Winds property.
    /// </summary>
    public PotentialOf45MphWinds? PotentialOf45MphWinds { get; set; }

    /// <summary>
    /// Gets or sets the Potential of 20 MPH Wind Gusts property.
    /// </summary>
    public PotentialOf20MphWindGusts? PotentialOf20MphWindGusts { get; set; }

    /// <summary>
    /// Gets or sets the Potential of 30 MPH Wind Gusts property.
    /// </summary>
    public PotentialOf30MphWindGusts? PotentialOf30MphWindGusts { get; set; }

    /// <summary>
    /// Gets or sets the Potential of 40 MPH Wind Gusts property.
    /// </summary>
    public PotentialOf40MphWindGusts? PotentialOf40MphWindGusts { get; set; }

    /// <summary>
    /// Gets or sets the Potential of 50 MPH Wind Gusts property.
    /// </summary>
    public PotentialOf50MphWindGusts? PotentialOf50MphWindGusts { get; set; }

    /// <summary>
    /// Gets or sets the Potential of 60 MPH Wind Gusts property.
    /// </summary>
    public PotentialOf60MphWindGusts? PotentialOf60MphWindGusts { get; set; }

    /// <summary>
    /// Gets or sets the Grassland Fire Danger Index property.
    /// </summary>
    public GrasslandFireDangerIndex? GrasslandFireDangerIndex { get; set; }

    /// <summary>
    /// Gets or sets the Probability of Thunder property.
    /// </summary>
    public ProbabilityOfThunder? ProbabilityOfThunder { get; set; }

    /// <summary>
    /// Gets or sets the Davis Stability Index property.
    /// </summary>
    public DavisStabilityIndex? DavisStabilityIndex { get; set; }

    /// <summary>
    /// Gets or sets the Atmospheric Dispersion Index property.
    /// </summary>
    public AtmosphericDispersionIndex? AtmosphericDispersionIndex { get; set; }

    /// <summary>
    /// Gets or sets the Low Visibility Occurrence Risk Index property.
    /// </summary>
    public LowVisibilityOccurrenceRiskIndex? LowVisibilityOccurrenceRiskIndex { get; set; }

    /// <summary>
    /// Gets or sets the Stability property.
    /// </summary>
    public Stability? Stability { get; set; }

    /// <summary>
    /// Gets or sets the Red Flag Threat Index property.
    /// </summary>
    public RedFlagThreatIndex? RedFlagThreatIndex { get; set; }
}