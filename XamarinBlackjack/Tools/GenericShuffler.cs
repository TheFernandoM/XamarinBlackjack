using System;
using System.Collections.Generic;

namespace XamarinBlackjack.Tools
{
    public static class GenericShuffler
    {
        /// <summary>
        /// Shuffles a list of objects. Runtime is O(n).
        /// <br></br>
        /// This implementation is based on
        /// Wikipedia's  pseudocode description of the modern version of the
        /// Fisher-Yates shuffle.
        ///
        /// Author: Fernando Molina
        /// </summary>
        public static List<T> ShuffleList<T>(List<T> list)
        {
            // the return type "T" (generic type) could be any type that inherits from System.Object

            Random rand = new Random();
            int deckSize = list.Count;

            for (int i = deckSize - 1; i > 1; i--)
            {
                int j = -1; // j here is just an index variable, like i

                while (!(0 <= j && j <= i)) // 0 ≤ j ≤ i
                {
                    // generate a random number for j until it falls between
                    // 0 and i, inclusive
                    j = rand.Next(0, deckSize + 1);
                }
                // swap positions of the two objects
                T temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
            return list;
        }
    }
}
