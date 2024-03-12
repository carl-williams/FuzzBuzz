using FuzzBuzz.Interfaces;

namespace FuzzBuzz.BL
{
    internal class FuzzBuzzGame : IFuzzBuzzGame
    {
        private const string FuzzString = "Fuzz";
        private const string BuzzString = "Buzz";

        public string GetTextForNumber(int number)
        {
            string result = "";
            if (number % 3 == 0)
            {
                result = "Fuzz";
            }
            if (number % 5 == 0)
            {
                result = $"{result}Buzz";
            }

            return string.IsNullOrEmpty(result) ? number.ToString() : result;
        }

        public string GetTextForNumberEnumerable(IEnumerable<int> numbers)
        {
            throw new NotImplementedException();
        }
    }
}
