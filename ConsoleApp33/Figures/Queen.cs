public class Queen : IFigureMoving
{
    public FiguresColor Color { get; }
    public int X { get; }
    public int Y { get; }

    public Queen(Possition poss, FiguresColor color)
    {
        Color = color;
        X = poss.X;
        Y = poss.Y;
    }

    public bool Mooving(int x, char y)
    {
        if ((Math.Abs(x - X) == 0 && Math.Abs(Y - y) != 0) || (Math.Abs(x - X) != 0 && Math.Abs(Y - y) == 0))
        {

            return true;
        }
        else if ((Math.Abs(x - X) == Math.Abs(Y - y)))
        {

            return true;
        }
        else return false;

    } 
}