public class Rook : IFigureMoving
{
    public FiguresColor Color { get; }
    public int X { get; }
    public int Y { get; }

    public Rook(Possition poss, FiguresColor color)
    {
        Color = color;
        X = poss.X;
        Y = poss.Y;
    }
    public bool Mooving(int x, char y)
    {
        if (((Math.Abs(x - X) == 0 && Math.Abs(y - Y) != 0)) || (Math.Abs(x - X) != 0 && Math.Abs(y - Y) == 0))
        {
            return true;
        }
        else return false;
    }
}