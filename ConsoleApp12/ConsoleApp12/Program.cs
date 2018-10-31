using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> collection = new List<int>();
            collection.Add(1);
            collection.Add(2);
            collection.Add(3);
            collection.Add(4);
            collection.Add(5);
            int sumElement = 0;
            

            for (int i = 0; i < collection.Count; i++)
            {
                if (i % 2 == 0)
                    sumElement = sumElement + collection[i];
               

            }
 
            int maxPosition = 0;
            int resultPosition = 0;
            int resultElement = 0;

            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i] == collection.Max()){
                    maxPosition = i;
                    collection.Remove(collection[i]);
                }
            }
 
            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i] == collection.Max()){
                    resultPosition = i;
                    resultElement = collection[i];
                }
            }
 
            if (maxPosition > resultPosition)
            {
                Console.WriteLine("Second max element : " + resultElement + " Position: " + resultPosition );
            }
            else
            {
                Console.WriteLine("Second max element : " + resultElement + " Position: " + (resultPosition + 1) );
            }

            Console.WriteLine("Sum: " + sumElement );

            Console.ReadLine();
        }
    }
}
