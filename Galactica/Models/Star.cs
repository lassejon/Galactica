using Galactica.Enums;
using Galactica.Models.Base;
using Microsoft.VisualBasic;

namespace Galactica.Models;

public class Star : SpaceObject
{
    public override Pos Position { get; set; } = new(0, 0);
    // Line below can be used to hide base implementation instead of virtual/override keywords
    // public new Pos? Position { get; init; } = new(0, 0);
    public StarType Type { get; set; }
    public double TemperatureInKelvin { get; set; }
    public List<Planet>? Planets { get; set; }

    public Star()
    {
        MakePlanetsOrbitThis();
    }

    public Star(List<Planet> planets)
    {
        Planets = planets;
        MakePlanetsOrbitThis();
    }

    private void MakePlanetsOrbitThis()
    {
        Planets?.ForEach(p => p.OrbitingStar = this);
    }

    public override string ToString()
    {
        var sun = $"Name: {Name} - Type: {Type} - Temperature: {TemperatureInKelvin} K ";
        var planets = "";
        if (Planets != null)
        {
            planets = $"- Planets:\n{string.Join("\n", Planets)}";
        }
        return sun + planets;
    }
}