using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string expected = "SAD";
            string message = "I am in SAD Mood";
            MoodAnalyser mood = new MoodAnalyser(null);

            // Act
            string mood1 = mood.AnalizeMood();

            //Assert
            Assert.AreEqual(expected, mood1);
        }
    }
}
