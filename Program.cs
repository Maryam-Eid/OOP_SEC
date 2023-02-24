using System;

namespace OOP_Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            //c# program to input elements in array from user and count even & odd elements in array.

            int EvenCounter = 0, OddCounter = 0, Size;

            //get the size from the user.
            Console.WriteLine("Please, Enter The Array Size: ");
            Size = int.Parse(Console.ReadLine());

            //array declaration.
            int[] Array = new int [Size];

            //inserting elements in the array.
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine("Please, Enter The Number {0} Element: ", i+1 );
                Array[i] = int.Parse (Console.ReadLine());
            }

            Console.WriteLine("------------------------------");

            //printing even elements.
            Console.Write("\nThe Even Elements Are: ");
            foreach (int element in Array) 
            {
                if (element %2 == 0) 
                {
                    Console.Write(element+", ");
                    EvenCounter++;
                }
            }
            Console.Write("Count Is: {0}.", EvenCounter );

            //printing odd elements.
            Console.Write("\n\nThe Odd Elements Are: ");
            foreach (int i in Array)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + ", ");
                    OddCounter++;
                }
            }
            Console.Write("Count Is: {0}.", OddCounter);

            Console.ReadLine();
        }
    }
}
