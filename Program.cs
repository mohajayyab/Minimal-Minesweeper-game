using System;

namespace game 
{
    class Program
    {
        static void FillWithBombs(int numberOfBombs, bool[,] map)
        {
            Random RNG = new Random();  // TODO!!!!
            int counter = 0;
            while (counter < numberOfBombs)
            {
                int x = RNG.Next(0, map.GetLength(1));
                int y = RNG.Next(0, map.GetLength(0));
                if (map[y, x] != true)
                {
                    map[y, x] = true;
                    counter++;
                }
            }
        }
        static void choose(int x, int y, bool[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    do 
                    {
                        Console.WriteLine("INER THE X INDEX");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine("INER THE Y INDEX");
                        y = int.Parse(Console.ReadLine());
                        if (matrix[x, y] == true)
                        {
                            Console.WriteLine("YOU WIN ");

                        }
                    }
                    while (matrix[x, y] == false);
                    

                }
            }
            
        }
        static void ShowMatrix(bool[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        } 

        static void Main(string[] args)
        {
            bool[,] board = new bool[2, 2];
            FillWithBombs(1, board);

            ShowMatrix(board);

            Console.WriteLine("INER THE X INDEX");
            int x =int.Parse(Console.ReadLine());
            Console.WriteLine("INER THE Y INDEX");
            int y = int.Parse(Console.ReadLine());

            choose(x, y, board);

        }
    }
}
