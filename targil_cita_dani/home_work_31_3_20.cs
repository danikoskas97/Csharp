using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] matrix = new string[3][];

            matrix[0] = new string[] { "main", "up", "sub" };
            matrix[1] = new string[] { "down", "center", "up" };
            matrix[2] = new string[] { "sub", "down", "main" };

            Console.WriteLine("-------matrix-------");
            foreach (string[] row in matrix)
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    string matrixCol = row[i];
                    Console.Write($"[ {matrixCol} ]");
                }
                Console.WriteLine();
            }


        }
    }
}
