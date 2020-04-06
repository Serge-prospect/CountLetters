using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLetters
{
    class SergeyKuzhalLetterCounter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text:");
            string input = Console.ReadLine();
            int events = 0;                                                         // Successful events
            int qty = 0;                                                            // Consecutive non-repeating letter quantity
            int i = 0;                                                              // Current letter
            int j = i+1;                                                            // Next letter
            for (i = 0; i < input.Length && j < input.Length; i++, j++)
            {                
                if (input[i] != input[j])
                    events++;                                                       // Count successful event
            }
            if (events > 0)
                qty = events + 1;                                                   // Count letters 
            Console.WriteLine($"Consecutive non-repeating letter quantity: {qty}");

            Console.ReadKey();
        }
    }
}
