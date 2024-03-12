using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzBuzz.Interfaces
{
    internal interface IFuzzBuzzGame
    {
        /// <summary>
        ///     Returns the following
        ///     if the number is divisible by 3 and 5 returns FuzzBuzz
        ///     if the number is divisible by 3 returns Fuzz
        ///     if the number is divisible by 5 returns Buzz
        ///     otherwise just the number as a string string
        /// </summary>
        /// <param name="number">The number to check</param>
        /// <returns>the string representation</returns>
        public string GetTextForNumber(int number);

        /// <summary>
        ///     Returns the FuzzBuzz string for the passed in Enumerable
        /// </summary>
        /// <param name="numbers">The numbers to be converted to the a string</param>
        /// <returns>Space delimited string of the FuzBuzz values of the numbers provided</returns>
        public string GetTextForNumberEnumerable(IEnumerable<int> numbers);
    }
}
