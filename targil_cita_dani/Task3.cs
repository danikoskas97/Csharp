using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int matrix;

            do
            {
                Console.WriteLine("pls enter the size of  the matrix: ");
                matrix = Convert.ToInt32(Console.ReadLine());
            } while (matrix == 0);

            yourChoice(matrix);

             static void yourChoice(int y)
            {
                string[][] yourmatrix = new string[y][];
                for (int row = 0; row < y; row++)
                {
                    yourmatrix[row] = new string[y];
                    for (int col = 0; col < y; col++)
                    {
                        if (y % 2 != 0 && y / 2 == row && y / 2 == col)
                            yourmatrix[row][col] = "center";
                        else if (row < col && row + col != y - 1)
                            yourmatrix[row][col] = "up";
                        else if(row > col && row + col != y - 1)
                            yourmatrix[row][col] = "down";
                        else if(row == col)
                            yourmatrix[row][col] = "main";
                        else if(row + col == y -1)
                            yourmatrix[row][col] = "sub";
                    }
                }
                foreach (string[] x in yourmatrix)
                {
                    foreach (string z in x)
                    {
                        Console.Write(z + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }  
        }
    }
}
