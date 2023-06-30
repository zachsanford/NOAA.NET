// <copyright file="Properties.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;

namespace NOAA.NET.Gridpoints;

/// <summary>
/// A representation of a Properties object.
/// </summary>
public class Properties
{
    /// <summary>
    /// Gets or sets the Id Property.
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the Type Property.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the Update Time Property.
    /// </summary>
    public DateTime? UpdateTime { get; set; }

    /// <summary>
    /// Gets or sets the Valid Times Property.
    /// </summary>
    public string? ValidTimes { get; set; }

    /// <summary>
    /// Gets or sets the Elevation Property.
    /// </summary>
    public Elevation? Elevation { get; set; }

    /// <summary>
    /// Gets or sets the Forecast Office Property.
    /// </summary>
    public string? ForecastOffice { get; set; }

    /// <summary>
    /// Gets or sets the Grid Id Property.
    /// </summary>
    public string? GridId { get; set; }

    /// <summary>
    /// Gets or sets the Grid X Property.
    /// </summary>
    public string? GridX { get; set; }

    /// <summary>
    /// Gets or sets the Grid Y Property.
    /// </summary>
    public string? GridY { get; set; }

    /// <summary>
    /// Gets or sets the Temperature Property.
    /// </summary>
    public Temperature? Temperature { get; set; }

    /// <summary>
    /// Gets or sets the Dewpoint Property.
    /// </summary>
    public Dewpoint? Dewpoint { get; set; }

    /// <summary>
    /// Gets or sets the Max Temperature Property.
    /// </summary>
    public MaxTemperature? MaxTemperature { get; set; }

    /// <summary>
    /// Gets or sets the Min Temperature Property.
    /// </summary>
    public MinTemperature? MinTemperature { get; set; }

    /// <summary>
    /// Gets or sets the Relative Humidity Property.
    /// </summary>
    public RelativeHumidity? RelativeHumidity { get; set; }

    /// <summary>
    /// Gets or sets the Apparent Temperature Property.
    /// </summary>
    public ApparentTemperature? ApparentTemperature { get; set; }

    /// <summary>
    /// Gets or sets the Wet Bulb Globe Temperature Property.
    /// </summary>
    public WetBulbGlobeTemperature? WetBulbGlobeTemperature { get; set; }

    /// <summary>
    /// Gets or sets the Heat Index Property.
    /// </summary>
    public HeatIndex? HeatIndex { get; set; }

    /// <summary>
    /// Gets or sets the Wind Chill Property.
    /// </summary>
    public WindChill? WindChill { get; set; }

    /// <summary>
    /// Gets or sets the Sky Cover Property.
    /// </summary>
    public SkyCover? SkyCover { get; set; }

    /// <summary>
    /// Gets or sets the Wind Direction Property.
    /// </summary>
    public WindDirection? WindDirection { get; set; }

    /// <summary>
    /// Gets or sets the Wind Speed Property.
    /// </summary>
    public WindSpeed? WindSpeed { get; set; }

    /// <summary>
    /// Gets or sets the Wind Gust Property.
    /// </summary>
    public WindGust? WindGust { get; set; }

    /// <summary>
    /// Gets or sets the Weather Property.
    /// </summary>
    public Weather? Weather { get; set; }

    /// <summary>
    /// Gets or sets the Hazards Property.
    /// </summary>
    public Hazards? Hazards { get; set; }

    /// <summary>
    /// Gets or sets the Probability of Precipitation Property.
    /// </summary>
    public ProbabilityOfPrecipitation? ProbabilityOfPrecipitation { get; set; }

    /// <summary>
    /// Gets or sets the Quantitative Precipitation Property.
    /// </summary>
    public QuantitativePrecipitation? QuantitativePrecipitation { get; set; }

    /// <summary>
    /// Gets or sets the Ice Accumulation Property.
    /// </summary>
    public IceAccumulation? IceAccumulation { get; set; }

    /// <summary>
    /// Gets or sets the Snowfall Amount Property.
    /// </summary>
    public SnowfallAmount? SnowfallAmount { get; set; }

    /// <summary>
    /// Gets or sets the Snow Level Property.
    /// </summary>
    public SnowLevel? SnowLevel { get; set; }

    /// <summary>
    /// Gets or sets the Ceiling Height Property.
    /// </summary>
    public CeilingHeight? CeilingHeight { get; set; }

    /// <summary>
    /// Gets or sets the Visibility Property.
    /// </summary>
    public Visibility? Visibility { get; set; }

    /// <summary>
    /// Gets or sets the Transport Wind Speed Property.
    /// </summary>
    public TransportWindSpeed? TransportWindSpeed { get; set; }

    /// <summary>
    /// Gets or sets the Transport Wind Direction Property.
    /// </summary>
    public TransportWindDirection? TransportWindDirection { get; set; }

    /// <summary>
    /// Gets or sets the Mixing Height Property.
    /// </summary>
    public MixingHeight? MixingHeight { get; set; }

    /// <summary>
    /// Gets or sets the Haines Index Property.
    /// </summary>
    public HainesIndex? HainesIndex { get; set; }

    /// <summary>
    /// Gets or sets the Lightning Activity Level Property.
    /// </summary>
    public LightningActivityLevel? LightningActivityLevel { get; set; }

    /// <summary>
    /// Gets or sets the Twenty Foot Wind Speed Property.
    /// </summary>
    public TwentyFootWindSpeed? TwentyFootWindSpeed { get; set; }

    /// <summary>
    /// Gets or sets the Twenty Foot Wind Direction Property.
    /// </summary>
    public TwentyFootWindDirection? TwentyFootWindDirection { get; set; }

    /// <summary>
    /// Gets or sets the Wave Height Property.
    /// </summary>
    public WaveHeight? WaveHeight { get; set; }

    /// <summary>
    /// Gets or sets the Wave Period Property.
    /// </summary>
    public WavePeriod? WavePeriod { get; set; }

    /// <summary>
    /// Gets or sets the Wave Direction Property.
    /// </summary>
    public WaveDirection? WaveDirection { get; set; }

    /// <summary>
    /// Gets or sets the Primary Swell Height Property.
    /// </summary>
    public PrimarySwellHeight? PrimarySwellHeight { get; set; }

    /// <summary>
    /// Gets or sets the Primary Swell Direction Property.
    /// </summary>
    public PrimarySwellDirection? PrimarySwellDirection { get; set; }

    /// <summary>
    /// Gets or sets the Secondary Swell Height Property.
    /// </summary>
    public SecondarySwellHeight? SecondarySwellHeight { get; set; }

    /// <summary>
    /// Gets or sets the Secondary Swell Direction Property.
    /// </summary>
    public SecondarySwellDirection? SecondarySwellDirection { get; set; }

    /// <summary>
    /// Gets or sets the Wave Period 2 Property.
    /// </summary>
    public WavePeriod2? WavePeriod2 { get; set; }

    /// <summary>
    /// Gets or sets the Wind Wave Height Property.
    /// </summary>
    public WindWaveHeight? WindWaveHeight { get; set; }

    /// <summary>
    /// Gets or sets the Dispersion Index Property.
    /// </summary>
    public DispersionIndex? DispersionIndex { get; set; }

    /// <summary>
    /// Gets or sets the Pressure Property.
    /// </summary>
    public Pressure? Pressure { get; set; }

    /// <summary>
    /// Gets or sets the Probability of Tropical Storm Winds Property.
    /// </summary>
    public ProbabilityOfTropicalStormWinds? ProbabilityOfTropicalStormWinds { get; set; }

    /// <summary>
    /// Gets or sets the Probability of Hurricane Winds Property.
    /// </summary>
    public ProbabilityOfHurricaneWinds? ProbabilityOfHurricaneWinds { get; set; }

    /// <summary>
    /// Gets or sets the Potential of 15 MPH Winds Property.
    /// </summary>
    public PotentialOf15MphWinds? PotentialOf15MphWinds { get; set; }

    /// <summary>
    /// Gets or sets the Potential of 25 MPH Winds Property.
    /// </summary>
    public PotentialOf25MphWinds? PotentialOf25MphWinds { get; set; }

    /// <summary>
    /// Gets or sets the Potential of 35 MPH Winds Property.
    /// </summary>
    public PotentialOf35MphWinds? PotentialOf35MphWinds { get; set; }

    /// <summary>
    /// Gets or sets the Potential of 45 MPH Winds Property.
    /// </summary>
    public PotentialOf45MphWinds? PotentialOf45MphWinds { get; set; }

    /// <summary>
    /// Gets or sets the Potential of 20 MPH Wind Gusts Property.
    /// </summary>
    public PotentialOf20MphWindGusts? PotentialOf20MphWindGusts { get; set; }

    /// <summary>
    /// Gets or sets the Potential of 30 MPH Wind Gusts Property.
    /// </summary>
    public PotentialOf30MphWindGusts? PotentialOf30MphWindGusts { get; set; }

    /// <summary>
    /// Gets or sets the Potential of 40 MPH Wind Gusts Property.
    /// </summary>
    public PotentialOf40MphWindGusts? PotentialOf40MphWindGusts { get; set; }

    /// <summary>
    /// Gets or sets the Potential of 50 MPH Wind Gusts Property.
    /// </summary>
    public PotentialOf50MphWindGusts? PotentialOf50MphWindGusts { get; set; }

    /// <summary>
    /// Gets or sets the Potential of 60 MPH Wind Gusts Property.
    /// </summary>
    public PotentialOf60MphWindGusts? PotentialOf60MphWindGusts { get; set; }

    /// <summary>
    /// Gets or sets the Grassland Fire Danger Index Property.
    /// </summary>
    public GrasslandFireDangerIndex? GrasslandFireDangerIndex { get; set; }

    /// <summary>
    /// Gets or sets the Probability of Thunder Property.
    /// </summary>
    public ProbabilityOfThunder? ProbabilityOfThunder { get; set; }

    /// <summary>
    /// Gets or sets the Davis Stability Index Property.
    /// </summary>
    public DavisStabilityIndex? DavisStabilityIndex { get; set; }

    /// <summary>
    /// Gets or sets the Atmospheric Dispersion Index Property.
    /// </summary>
    public AtmosphericDispersionIndex? AtmosphericDispersionIndex { get; set; }

    /// <summary>
    /// Gets or sets the Low Visibility Occurrence Risk Index Property.
    /// </summary>
    public LowVisibilityOccurrenceRiskIndex? LowVisibilityOccurrenceRiskIndex { get; set; }

    /// <summary>
    /// Gets or sets the Stability Property.
    /// </summary>
    public Stability? Stability { get; set; }

    /// <summary>
    /// Gets or sets the Red Flag Threat Index Property.
    /// </summary>
    public RedFlagThreatIndex? RedFlagThreatIndex { get; set; }
}