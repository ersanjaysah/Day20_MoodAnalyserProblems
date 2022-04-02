using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Given_Empty_Mood_Should_Throw_MoodAnalyseException_Indicating_EmptyMood()
        {
            try
            {
                string message = " ";
                MoodAnalyser moodAnaliser = new MoodAnalyser(message);
                string mood = moodAnaliser.AnalizeMood();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }
    }
}
