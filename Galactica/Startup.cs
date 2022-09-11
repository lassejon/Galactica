using Galactica.Repositories;

namespace Galactica;

public static class Startup
{
    public static void Start()
    {
        Console.WriteLine(SpaceObjectRepository.Sun);
    }
}