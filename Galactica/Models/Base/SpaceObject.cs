namespace 
    Galactica.Models.Base;

public abstract class SpaceObject
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public Position Position { get; set; }
}

public class Position
{
    public Position(int x, int y)
    {
        X = x;
        Y = y;
    }
    
    public int X { get; set; }
    public int Y { get; set; }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

