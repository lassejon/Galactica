using Galactica.Models.Base;

namespace Galactica.Models;

public sealed class Moon : Planet
{
    public Planet Orbiting { get; set; }

    public new double Distance()
    {
        var xDistanceSquared = Math.Pow(Position.X - Orbiting.Position.X, 2);
        var yDistanceSquared = Math.Pow(Position.Y  - Orbiting.Position.Y, 2);

        return Math.Sqrt(xDistanceSquared + yDistanceSquared);
    }

    public override string ToString()
    {
        return $"  - {Name} - Type: {PlanetType} - Distance to the {Orbiting.Name}: {Distance()}";
    }
}