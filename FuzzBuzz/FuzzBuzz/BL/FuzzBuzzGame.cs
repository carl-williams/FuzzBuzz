using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FuzzBuzz.Interfaces;

namespace FuzzBuzz.BL
{
    internal class FuzzBuzzGame : IFuzzBuzzGame
    {
        public string GetTextForNumber(int number)
        {
            throw new NotImplementedException();
        }

        public string GetTextForNumberEnumerable(IEnumerable<int> numbers)
        {
            throw new NotImplementedException();
        }
    }
}
