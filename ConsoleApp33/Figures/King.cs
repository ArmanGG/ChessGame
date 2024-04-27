public class King : IFigureMoving
{
    public FiguresColor Color { get; }
    public int X {  get; }
    public int Y { get; }

    public King(Possition poss, FiguresColor color)
    {
        Color = color;
        X = poss.X;
        Y = poss.Y;
    }
    public bool Mooving(int x, char y) {
     
        if (((Math.Abs(x - X) == 1 && Math.Abs(y - Y) == 1) || (Math.Abs(x - X) == 0 && Math.Abs(y - Y) ==1) || (Math.Abs(x - X) == 1 && Math.Abs(y - Y) == 0)))
        {       
                return true;
        }
        return false;   
    }
}