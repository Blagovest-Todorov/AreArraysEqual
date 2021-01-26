using System;
using System.Linq;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrOne = Console.ReadLine()
                           .Split()
                           .Select(int.Parse)
                           .ToArray();

            int[] arrTwo = Console.ReadLine()
                           .Split()
                           .Select(int.Parse)
                           .ToArray();

            bool areEqual = true;
            int sum = 0;
            string result = string.Empty;

            for (int i = 0; i < arrOne.Length; i++)
            {
                if (arrOne[i] != arrTwo[i])
                {                    
                    areEqual = false;
                        // indexNum = i;                       
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index"); 
                    break;
                }                    
                else //   (arrOne[i] == arrTwo[i])
                {
                    sum += arrOne[i];
                }

                result = ($"Arrays are identical. Sum: {sum}");
            }

            if (result != string.Empty)
            {
                Console.WriteLine(result);
            }
            
        }
    }
}
