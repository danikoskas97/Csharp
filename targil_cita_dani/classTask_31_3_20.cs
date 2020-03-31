using System;

namespace lesson03
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClassTask
            int numOfRows;
            do
            {
                Console.WriteLine("pls enter a number : between (3-9)");
                numOfRows = Convert.ToInt32(Console.ReadLine());

            } while (numOfRows < 3|| numOfRows > 9);

            int[][] matrix = new int[numOfRows][];
            int x = 1;

            for (int row = 0; row < matrix.Length; row++, x++)
            {
                matrix[row]= new int[row + 1];
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = x;
                }
            }
            foreach (int[] row in matrix)
            {
                foreach (var col in row)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }

            //-------------------------------------------------

            //print simple matrix of String
            string[] names = new string[3] { "david", "moshe", "dani" };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine();
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }

            print simple matrix of int
            int[] arrNum = new int[] { 1, 2, 3 };

            for (int i = 0; i < arrNum.Length; i++)
            {
                Console.WriteLine(arrNum[i]);
            }
            Console.WriteLine();
            foreach (int item in arrNum)
            {
                Console.WriteLine(item);
            }

            //-------------------------------------------------

            //print age and validate if the age is between 0 and 120 if not re-eenter age
            int age;
            do
            {
                Console.WriteLine("enter your age 0-120");
                age = Convert.ToInt32(Console.ReadLine());

            } while (age<0 || age > 120);

            Console.WriteLine($"Your age is : {age} Year old");

            //-------------------------------------------------
            
            int numOfRows;
            do
            {
                Console.WriteLine("please enter a number");
                numOfRows = Convert.ToInt32(Console.ReadLine());
            } while (numOfRows < 2 || numOfRows > 5);

            bool[][] matbool = new bool[numOfRows][];

            for (int i = 0; i < matbool.Length; i++)
            {
                matbool[i] = new bool[i + 1];

                for (int col = 0; col < matbool[i].Length; col++)
                {
                    if (i % 2 == 0)
                        matbool[i][col] = true;
                    else
                        matbool[i][col] = false;
                }
            }
            foreach (bool[] r in matbool)
            {
                foreach (bool r1 in r)
                {
                    Console.Write(r1 + " ");
                }
                Console.WriteLine();
            }
            //-------------------------------------------------
                
        }
    }
}
