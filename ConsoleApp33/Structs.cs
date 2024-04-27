
public struct Possition
{
    public int X ;
    public int Y ;
    public Possition(int x, char y)
    {
        try
        {
            
            if (x > 0 && x < 9 && Enum.IsDefined(typeof(PossY), (PossY)y))
            {
                X = x;
                Y = (int)Enum.Parse(typeof(PossY),y.ToString()); 
                
            }
            else
            {
                throw new ArgumentException("Invalid arguments for Possition");
            }
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.ToString());
        }
       
    }
}




//struct PossMas
//{
//    private char[,] S;
//    public PossMas()
//    {
//        S = new char[9, 18];
//        for (int i = 0; i < 9; i++)
//        {
//            S[i, 0] = '1';
//        }

//        for (int j = 0; j < 17; j++)
//        {
//            S[0, j] = '1';
//        }
//    }
//    public void Write(int x, int y, char c)
//    {
//        S[x, y] = c;
//    }

//    public char Read(int x, int y)
//    {
//        return S[x, y];
//    }
//}