using System;
using System.Collections.Generic;

namespace YieldKeyword
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            foreach (var item in SampleList(1, 10))
            {
                Console.WriteLine($"Update item is {item}");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Samples the list.
        /// </summary>
        /// <param name="startNumber">The start number.</param>
        /// <param name="endNumber">The end number.</param>
        /// <returns></returns>
        private static IEnumerable<string> SampleList(int startNumber, int endNumber)
        {
            for (int i = startNumber; i <= endNumber; i++)
            {
                yield return $"String {i} - updated";
            }
        }
    }
}
