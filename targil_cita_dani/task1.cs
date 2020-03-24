using System;

namespace lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
            //targil cita

            // take an input from the user an convert it to int
            Console.WriteLine("enter len of array :");
            int lenOfArray = Convert.ToInt32(Console.ReadLine());

            // take an input from the user and convert into int
            Console.WriteLine("enter num of multiply: ");
            int NumToMul = Convert.ToInt32(Console.ReadLine());

            //creat an array and take the len of the array from the user
            int[] arr = new int[lenOfArray];
            Console.WriteLine($"num of elements : {lenOfArray}, num to multiply : {NumToMul}");
            for (int i = 0; i < arr.Length; i++)
            {
                //do the multiply of what we have taken from the user
                arr[i] = i * NumToMul;
                //print the array
                Console.Write(arr[i] + ", ");
            }


        }
    }
}


