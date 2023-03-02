using System;
using System.ComponentModel.Design;

namespace OOP_Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# program to input elements in array and search whether an element exists in array or not.

            int Size, Find;
            bool Found = false;

            //get the size from the user.
            Console.WriteLine("Please, Enter The Array Size: ");
            Size = int.Parse(Console.ReadLine());

            //array declaration.
            int[] Array = new int[Size];

            //inserting elements in the array.
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine("Please, Enter The Number {0} Element: ", i + 1);
                Array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("------------------------------------");

            //get the element to search from the user.
            Console.WriteLine("\nPlease, Enter The Element To Search: ");
            Find = int.Parse(Console.ReadLine());

            //searching for the element.
            for (int i = 0; i < Array.Length;++i)  
            {
                if (Array[i] == Find)
                {
                    Found = true;
                    Console.WriteLine("\nThe Element {0} Is Found At Index {1}.", Find, i);
                    break;
                }
            }

            //if the element doesn't exists.
            if (!Found)
                Console.WriteLine("\nElement {0} Not Found.", Find);

            Console.ReadLine();
        }
    }
}
