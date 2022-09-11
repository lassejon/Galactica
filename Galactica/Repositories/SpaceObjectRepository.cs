using Galactica.Enums;
using Galactica.Models;
using Galactica.Models.Base;

namespace Galactica.Repositories;

public static class SpaceObjectRepository
{
    private static readonly Planet Mercury = new ()
    {
        Id = 1,
        Name = "Mercury",
        DiameterInMeters = 4879400,
        PlanetType = PlanetType.Terrestial,
        RevolutionPeriodInDays = 88,
        RotationPeriodInHours = 1408,
        Position = new Position(1, 0),
    };

    private static readonly Planet Venus = new ()
    {
        Id = 2,
        Name = "Venus",
        DiameterInMeters = 12104000,
        PlanetType = PlanetType.Terrestial,
        RevolutionPeriodInDays = 225,
        RotationPeriodInHours = 5832,
        Position = new Position(2, 0),
    };
    
    private static readonly Moon Luna = new ()
    {
        Id = 10,
        Name = "Luna",
        DiameterInMeters = 3474800,
        PlanetType = PlanetType.Dwarf,
        RevolutionPeriodInDays = 27,
        Position = new Position(3, 1),
    };

    private static readonly Planet Earth = 
        new (new List<Moon> { Luna })
    {
        Id = 3,
        Name = "Earth",
        DiameterInMeters = 12742000,
        PlanetType = PlanetType.Terrestial,
        RevolutionPeriodInDays = 365,
        RotationPeriodInHours = 24,
        Position = new Position(3, 0),
    };
    
    
    private static readonly Moon Phobos = new ()
    {
        Id = 12,
        Name = "Phobos",
        DiameterInMeters = 22533000,
        PlanetType = PlanetType.Terrestial,
        RevolutionPeriodInDays = 0.334,
        Position = new Position(4, 1),
    };
    
    private static readonly Moon Deimos = new ()
    {
        Id = 14,
        Name = "Deimos",
        DiameterInMeters = 12400,
        PlanetType = PlanetType.Terrestial,
        RevolutionPeriodInDays = 1.25,
        Position = new Position(4, 2),
    };

    private static readonly Planet Mars = 
        new (new List<Moon> { Phobos, Deimos })
    {
        Id = 4,
        Name = "Mars",
        DiameterInMeters = 6778000,
        PlanetType = PlanetType.Terrestial,
        RevolutionPeriodInDays = 687,
        RotationPeriodInHours = 24.7,
        Position = new Position(4, 0),
    };
    
    
    private static readonly Moon Io = new ()
    {
        Id = 16,
        Name = "Io",
        DiameterInMeters = 3643200,
        PlanetType = PlanetType.Terrestial,
        RevolutionPeriodInDays = 3.5,
        Position = new Position(5, 1),
    };
    
    private static readonly Moon Europe = new ()
    {
        Id = 13,
        Name = "Europe",
        DiameterInMeters = 3121600,
        PlanetType = PlanetType.Terrestial,
        RevolutionPeriodInDays = 1.75,
        Position = new Position(5, 2),
    };
    
    private static readonly Moon Ganymede = new ()
    {
        Id = 15,
        Name = "Europe",
        DiameterInMeters = 5268200,
        PlanetType = PlanetType.Terrestial,
        RevolutionPeriodInDays = 7.167,
        Position = new Position(5, 5),
    };

    private static readonly Planet Jupiter = 
        new (new List<Moon> { Io, Europe, Ganymede })
    {
        Id = 5,
        Name = "Jupiter",
        DiameterInMeters = 139820000,
        PlanetType = PlanetType.Gas_Giant,
        RevolutionPeriodInDays = 4380,
        RotationPeriodInHours = 9.925,
        Position = new Position(5, 0),
    };
    
    
    private static readonly Moon Titan = new ()
    {
        Id = 11,
        Name = "Titan",
        DiameterInMeters = 6149500,
        PlanetType = PlanetType.Terrestial,
        RevolutionPeriodInDays = 16,
        Position = new Position(6, 1),
    };
    
    private static readonly Moon Mimas = new ()
    {
        Id = 17,
        Name = "Mimas",
        DiameterInMeters = 396400,
        PlanetType = PlanetType.Terrestial,
        RevolutionPeriodInDays = 0.9583,
        Position = new Position(6, 2),
    };

    private static readonly Planet Saturn = 
        new (new List<Moon> { Titan, Mimas })
    {
        Id = 6,
        Name = "Saturn",
        DiameterInMeters = 116460000,
        PlanetType = PlanetType.Gas_Giant,
        RevolutionPeriodInDays = 10585,
        RotationPeriodInHours = 10.7,
        Position = new Position(6, 0),
    };

    private static readonly Planet Uranus = new ()
    {
        Id = 7,
        Name = "Uranus",
        DiameterInMeters = 50724000,
        PlanetType = PlanetType.Giant,
        RevolutionPeriodInDays = 30660,
        RotationPeriodInHours = 17,
        Position = new Position(7, 0),
    };

    private static readonly Planet Neptun = new ()
    {
        Id = 8,
        Name = "Neptun",
        DiameterInMeters = 49244000,
        PlanetType = PlanetType.Giant,
        RevolutionPeriodInDays = 60225,
        RotationPeriodInHours = 16,
        Position = new Position(8, 0),
    };

    private static readonly Planet Pluto = new ()
    {
        Id = 9,
        Name = "Pluto",
        DiameterInMeters = 2376600,
        PlanetType = PlanetType.Dwarf,
        RevolutionPeriodInDays = 90520,
        RotationPeriodInHours = 153,
        Position = new Position(9, 0),
    };
    
    public static Star Sun { get; } = 
        new (
            new List<Planet>
                {
                    Mercury,
                    Venus,
                    Earth,
                    Mars,
                    Jupiter,
                    Saturn,
                    Uranus,
                    Neptun,
                    Pluto
                }
            )
    {
        Name = "Sun",
        Id = 0,
        Position = new Position(0, 0),
        TemperatureInKelvin = 5778,
        Type = StarType.YellowDwarf,
    };
}