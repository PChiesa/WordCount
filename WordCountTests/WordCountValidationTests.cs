
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCount;

namespace WordCountTests
{
    [TestClass]
    public class WordCountValidationTests
    {
        private WordCountValidation wordCount;


        [TestInitialize]
        public void Init()
        {
            wordCount = new WordCountValidation();
        }

        [TestMethod]
        public void ShouldCount5DifferentLetters()
        {
            var letters = wordCount.CountWords("ANAGRAMA");
            var differentLetters = letters.Count;

            Assert.AreEqual(5, differentLetters);
            Assert.AreEqual(4, letters['A']);
            Assert.AreEqual(1, letters['N']);
            Assert.AreEqual(1, letters['G']);
            Assert.AreEqual(1, letters['R']);
            Assert.AreEqual(1, letters['M']);
        }

        [TestMethod]
        public void ShouldCount2DifferentLetters()
        {
            var letters = wordCount.CountWords("ARARA");
            var differentLetters = letters.Count;

            Assert.AreEqual(2, differentLetters);
            Assert.AreEqual(3, letters['A']);
            Assert.AreEqual(2, letters['R']);
        }

    }
}
