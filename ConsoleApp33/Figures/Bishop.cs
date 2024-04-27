public class Bishop : IFigureMoving
{
    public FiguresColor Color { get; }
    public int X { get; }
    public int Y { get; }

    public Bishop(Possition poss, FiguresColor color)
    {
        Color = color;
        X = poss.X;
        Y = poss.Y;
    }
    public bool Mooving(int x, char y)
    {
        if (Math.Abs(x - X) == Math.Abs(y - Y))
        {
            return true;
        }
        else return false;
    }
}