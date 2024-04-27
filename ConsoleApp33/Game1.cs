public static class Game1
{
    public static void PlayGame()
    {
        while (true)
        {
            Console.SetCursorPosition(0, 9);
            Console.WriteLine("Insert Possition(A8,B4,C3....)");
            Console.SetCursorPosition(0, 10);
            Console.WriteLine("Insert Figure(K,Q,B,N,R)");
            int poss = 9;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(30, poss);
            Console.WriteLine("                  ");
            Console.SetCursorPosition(30, poss + 1);
            Console.WriteLine("                  ");
            Console.SetCursorPosition(30, poss);
            string s1 = Console.ReadLine();
            Console.SetCursorPosition(0, 11);
            Console.WriteLine("                          ");
            Console.SetCursorPosition(30, poss + 1);
            string s2 = Console.ReadLine();
            Console.SetCursorPosition(30, 0);
            Console.Write("Insert NEXT Possition(A8,B4,C3....)");
            string a1 = Console.ReadLine();
            Console.SetCursorPosition(30, 1);
            Console.Write("Insert Figure(K,Q,B,N,R)");
            string a2 = Console.ReadLine();
            Console.SetCursorPosition(30, 30);
        }
        

    }
}