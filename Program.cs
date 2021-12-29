using System;

namespace c_sharp_odev_diziler
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] colors = new string[5];
            string[] animals = {"dog", "cat", "bird"};

            int[] array1;
            array1 = new int[5];


            colors[0] = "blue";
            array1[2] = 10;


            Console.WriteLine(animals[1]);
            Console.WriteLine(array1[2]);
            Console.WriteLine(colors[0]);


            Console.Write("Enter length for array: ");
            int arrayLength = int.Parse( Console.ReadLine() );
            int[] numbers = new int[arrayLength];


            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Enter {0}. number: ", i+1);
                numbers[i] = int.Parse( Console.ReadLine() );                
            } 

            int totalNumber = 0;
            foreach(var item in numbers )
            {
                totalNumber += item;
            }


            Console.WriteLine("Average: " + totalNumber/arrayLength );

        











        }
    }
}
