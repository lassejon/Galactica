using Galactica.Enums;
using Galactica.Models.Base;

namespace Galactica.Models;

public class Planet : SpaceObject
{
    public PlanetType PlanetType { get; set; }
    public int DiameterInMeters { get; set; }
    public double RotationPeriodInHours { get; set; }
    public double RevolutionPeriodInDays { get; set; }
    public List<Moon>? Moons { get; set; }
    public Star? OrbitingStar { get; set; }

    public double Distance()
    {
        var xDistanceSquared = Math.Pow(Position.X - OrbitingStar.Position.X, 2);
        var yDistanceSquared = Math.Pow(Position.Y  - OrbitingStar.Position.Y, 2);

        return Math.Sqrt(xDistanceSquared + yDistanceSquared);
    }

    public Planet()
    {
        MakeMoonsOrbitThis();
    }

    public Planet(List<Moon> moons)
    {
        Moons = moons;
        MakeMoonsOrbitThis();
    }
    
    private void MakeMoonsOrbitThis()
    {
        Moons?.ForEach(p => p.Orbiting = this);
    }

    public override string ToString()
    {
        var planet = $"- {Name} - Type: {PlanetType} - Distance to the {OrbitingStar.Name}: {Distance()} ";
        var moons = "";
        if (Moons != null)
        {
            moons = $"- Moons:\n{string.Join("\n", Moons)}";
        }
        return planet + moons;
    }
}