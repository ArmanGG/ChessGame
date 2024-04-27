public class Knight : IFigureMoving
{
    public FiguresColor Color { get; }
    public int X { get; }
    public int Y { get; }

    public Knight(Possition poss, FiguresColor color)
    {
        Color = color;
        X = poss.X;
        Y = poss.Y;
    }

    public bool Mooving(int x, char y)
    {
        if (((Math.Abs(X - x) == 1 && Math.Abs(Y - y) == 2) || (Math.Abs(X - x) == 2 && Math.Abs(Y - y) == 1)))
        {
            return true;
        }
        else return false;
    }
}