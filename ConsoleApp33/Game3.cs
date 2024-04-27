public static class Game3
{
    public static void PlayGame()
    {
        //Possition QueenPoss = new Possition(1, 'A');
        //FiguresColor figuresColor = new FiguresColor();
        //figuresColor = FiguresColor.white;
        //WriteLinePoss(QueenPoss.X, QueenPoss.Y, 'Q');
        //IFigureMoving figureMoving = new Queen(QueenPoss, figuresColor);

        //if (figureMoving.Mooving(8, 'B'))
        //{
        //    Thread.Sleep(1000);
        //    WriteLinePoss(QueenPoss.X, QueenPoss.Y , ' ');
        //    QueenPoss = new Possition(8, 'B');
        //    WriteLinePoss(QueenPoss.X, QueenPoss.Y , 'Q');
        //
        //}
        Possition KnightPoss = new Possition(1, 'A');
        FiguresColor figuresColor = new FiguresColor();
        figuresColor = FiguresColor.white;
        WriteLinePoss(KnightPoss.X, KnightPoss.Y, 'N');
        IFigureMoving figureMoving = new Knight(KnightPoss, figuresColor);

        if (figureMoving.Mooving(2, 'A'))
        {
            Thread.Sleep(1000);
            WriteLinePoss(KnightPoss.X, KnightPoss.Y, ' ');
            KnightPoss = new Possition(2, 'A');
            WriteLinePoss(KnightPoss.X, KnightPoss.Y, 'N');

        }

        void WriteLinePoss(int X, int Y, char Letter)
        {
            X = 8 - X;
            int y = Y*2 -128;
            Console.SetCursorPosition(y, X);
            if (((y == 1 || y == 2 || y == 5 || y == 6 || y == 9 || y == 10 || y == 13 || y == 14)) && (X % 2 == 0))
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Letter);
            }
            else if (((y == 3 || y == 4 || y == 7 || y == 8 || y == 11 || y == 12 || y == 15 || y == 16)) && (X % 2 == 1))
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Letter);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Letter);
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 12);

        }

    }
}