namespace 
    Galactica.Models.Base;

public abstract class SpaceObject
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public virtual Pos Position { get; set; }
    
    public class Pos
    {
        public Pos(int x, int y)
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
}

