using FuzzBuzz.BL;
using FuzzBuzz.Interfaces;

namespace FuzzBuzz.Test
{
    internal class MultipleNumbersTests
    {
        private readonly IFuzzBuzzGame GameEngine;

        public MultipleNumbersTests()
        {
            GameEngine = new FuzzBuzzGame();
        }

        [Test]
        public void AllNumbersDivBy3ReturnsAllFuzz()
        {
            var numbers = new List<int>
            {
                3, 6, 9,
                12, 18,
                21, 24, 27,
                33, 36, 39,
                42, 48,
                51, 54, 57,
                63, 66, 69,
                72, 78,
                81, 84, 87,
                93, 96, 99
            };

            var gameResult = GameEngine.GetTextForNumberEnumerable(numbers);
            var expectedresult = string.Concat(Enumerable.Repeat("Fuzz ", 36));
            Assert.That(gameResult, Is.EqualTo(expectedresult));
        }

        [Test]
        public void AllNumbersDivBy5ReturnsAllBuzz()
        {
            var numbers = new List<int>
            {
                5,
                10,
                20,
                25,
                35,
                40,
                50,
                55,
                65,
                70,
                80,
                85,
                95
            };

            var gameResult = GameEngine.GetTextForNumberEnumerable(numbers);
            var expectedresult = string.Concat(Enumerable.Repeat("Buzz ", 13));
            Assert.That(gameResult, Is.EqualTo(expectedresult));
        }

        [Test]
        public void AllNumbersDivBy3And5ReturnsAllBuzz()
        {
            var numbers = new List<int>
            {
                15,
                30,
                45,
                60,
                75,
                90
            };

            var gameResult = GameEngine.GetTextForNumberEnumerable(numbers);
            var expectedresult = string.Concat(Enumerable.Repeat("FuzzBuzz ", 6));
            Assert.That(gameResult, Is.EqualTo(expectedresult));
        }

        [Test]
        public void NumberChainReturnsCorrectStriing()
        {
            var numbers = new List<int>
            {
                2, 5, 9,
                23,
                30,
                38, 39,
                12,
                40, 47
            };
            var gameResult = GameEngine.GetTextForNumberEnumerable(numbers);
            var expectedresult = "2 Buzz Fuzz 23 FuzzBuzz 38 39 Fuzz Buzz 47";
            Assert.That(gameResult, Is.EqualTo(expectedresult));
        }
    }
}
