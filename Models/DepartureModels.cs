using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL_Skylt.Models;

public class Departure
{
    public string Destination { get; set; } = string.Empty;
    public int DirectionCode { get; set; } = 0;
    public string Direction { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string Display { get; set; } = string.Empty;
    public DateTime Scheduled { get; set; } = DateTime.MinValue;
    public DateTime Expected { get; set; } = DateTime.MinValue;
    public Journey Journey { get; set; } = new Journey();
    public StopArea StopArea { get; set; } = new StopArea();
    public StopPoint StopPoint { get; set; } = new StopPoint();
    public Line Line { get; set; } = new Line();
    public List<object> Deviations { get; set; } = new List<object>();
}

public class Journey
{
    public long Id { get; set; } = 0;
    public string State { get; set; } = string.Empty;
    public string PredictionState { get; set; } = string.Empty;
}

public class StopArea
{
    public int Id { get; set; } = 0;
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
}

public class StopPoint
{
    public int Id { get; set; } = 0;
    public string Name { get; set; } = string.Empty;
    public string Designation { get; set; } = string.Empty;
}

public class Line
{
    public int Id { get; set; } = 0;
    public string Designation { get; set; } = string.Empty;
    public string Transport_mode { get; set; } = string.Empty;
    public string GroupOfLines { get; set; } = string.Empty;
}

public class DeparturesResponse
{
    public List<Departure> Departures { get; set; } = new List<Departure>();
    public List<object> StopDeviations { get; set; } = new List<object>();
}
