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
            string message = "I am in HAPPY Mood";
            MoodAnalyser mood = new MoodAnalyser(message);

            // Act
            string mood1 = mood.AnalizeMood();

            //Assert
            Assert.AreEqual(expected, mood1);
        }
    }
}
