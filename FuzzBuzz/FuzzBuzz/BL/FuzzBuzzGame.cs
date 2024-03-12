using FuzzBuzz.Interfaces;

namespace FuzzBuzz.BL
{
    internal class FuzzBuzzGame : IFuzzBuzzGame
    {
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
            return string.Join(' ', numbers.Select(n => GetTextForNumber(n)));
        }
    }
}
