using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MoodAnalyzerTestCase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMessage_ReturnSadMood()
        {
            //Arange
            string msg = "I am in SAD Mood";
            MoodAnalyzerClass mood = new MoodAnalyzerClass();
            string expected = "sad";

            ///Act
            string actual = mood.AnalyseMood(msg);
            ///Asert
            Assert.AreEqual(expected, actual);
        }
    }
}