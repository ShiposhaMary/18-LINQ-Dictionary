using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dictionary_by_LINQ
{
    class Program
    {
        public static string[] GetSortedWords(params string[] textLines)
        {
            //return ( String.Join(" ", textLines)
            //              .Split(new char[] { ' ', '.', ',', '\'', ';' },StringSplitOptions.RemoveEmptyEntries)
            //              .Select(x => x.ToLower())
            //              .Distinct()
            //             .GroupBy(x=> x)
            //             .OrderBy(y => y.Key)
            //           .Select(z => z.OrderBy(word => word))
            //         .SelectMany(f => f.AsEnumerable())
            //         .ToArray());    
            return textLines
    .SelectMany(x => x.Split(new char[] { ' ', ',', ';', '.', '\'' }))
    .Select(x => x.ToLower())
    .Distinct()
    .OrderBy(x => x)
    .ToArray();
        }
        public static void Main()
        {
            var vocabulary = GetSortedWords(
                "Hello, hello, hello, how low",
                "",
                "With the lights out, it's less dangerous",
                "Here we are now; entertain us",
                "I feel stupid and contagious",
                "Here we are now; entertain us",
                "A mulatto, an albino, a mosquito, my libido...",
                "Yeah, hey"
            );
            foreach (var word in vocabulary)
                Console.WriteLine(word);
            Console.ReadKey();
        }
    }
}
