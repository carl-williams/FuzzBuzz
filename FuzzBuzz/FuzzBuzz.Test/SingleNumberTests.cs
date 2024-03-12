using FuzzBuzz.BL;
using FuzzBuzz.Interfaces;

namespace FuzzBuzz.Test
{
    internal class SingleNumberTests
    {
        private readonly IFuzzBuzzGame GameEngine;
        private const string FuzzWord = "Fuzz";
        private const string BuzzWord = "Buzz";

        public SingleNumberTests()
        {
            GameEngine = new FuzzBuzzGame();
        }

        [Test]
        public void Number1Returns1()
        {
            var gameResult = GameEngine.GetTextForNumber(1);
            Assert.That(gameResult, Is.EqualTo("1"));
        }

        [Test]
        public void Number2Returns2()
        {
            var gameResult = GameEngine.GetTextForNumber(2);
            Assert.That(gameResult, Is.EqualTo("2"));
        }

        [Test]
        public void Number3ReturnsFuzz()
        {
            var gameResult = GameEngine.GetTextForNumber(3);
            Assert.That(gameResult, Is.EqualTo(FuzzWord));
        }

        [Test]
        public void Number4Returns4()
        {
            var gameResult = GameEngine.GetTextForNumber(4);
            Assert.That(gameResult, Is.EqualTo("4"));
        }

        [Test]
        public void Number5ReturnsBuzz()
        {
            var gameResult = GameEngine.GetTextForNumber(5);
            Assert.That(gameResult, Is.EqualTo(BuzzWord));
        }

        [Test]
        public void Number6ReturnsFuzz()
        {
            var gameResult = GameEngine.GetTextForNumber(6);
            Assert.That(gameResult, Is.EqualTo(FuzzWord));
        }

        [Test]
        public void Number7Returns7()
        {
            var gameResult = GameEngine.GetTextForNumber(7);
            Assert.That(gameResult, Is.EqualTo("7"));
        }

        [Test]
        public void Number8Returns8()
        {
            var gameResult = GameEngine.GetTextForNumber(8);
            Assert.That(gameResult, Is.EqualTo("8"));
        }

        [Test]
        public void Number9Returns9()
        {
            var gameResult = GameEngine.GetTextForNumber(9);
            Assert.That(gameResult, Is.EqualTo(FuzzWord));
        }

        [Test]
        public void Number10ReturnsBuzz()
        {
            var gameResult = GameEngine.GetTextForNumber(10);
            Assert.That(gameResult, Is.EqualTo(BuzzWord));
        }

        [Test]
        public void Number11Returns11()
        {
            var gameResult = GameEngine.GetTextForNumber(11);
            Assert.That(gameResult, Is.EqualTo("11"));
        }

        [Test]
        public void Number12ReturnsFuzz()
        {
            var gameResult = GameEngine.GetTextForNumber(12);
            Assert.That(gameResult, Is.EqualTo(FuzzWord));
        }

        [Test]
        public void Number13Returns13()
        {
            var gameResult = GameEngine.GetTextForNumber(13);
            Assert.That(gameResult, Is.EqualTo("13"));
        }

        [Test]
        public void Number14Returns14()
        {
            var gameResult = GameEngine.GetTextForNumber(14);
            Assert.That(gameResult, Is.EqualTo("14"));
        }

        [Test]
        public void Number15ReturnsFuzzBuzz()
        {
            var gameResult = GameEngine.GetTextForNumber(15);
            Assert.That(gameResult, Is.EqualTo($"{FuzzWord}{BuzzWord}"));
        }
    }
}
