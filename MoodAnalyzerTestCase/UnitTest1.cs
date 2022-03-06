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
            string msg = "I am in sad Mood";
            MoodAnalyzerClass mood = new MoodAnalyzerClass("msg");
            string expected = "sad";

            ///Act
            string actual = mood.AnalyseMood();

            ///Asert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenAnyMessage_ReturnHappyMood()
        {
            //Arange
            string msg = "I am in any Mood";
            MoodAnalyzerClass mood = new MoodAnalyzerClass("msg");
            string expected = "happy";

            ///Act
            string actual = mood.AnalyseMood();

            ///Asert
            Assert.AreEqual(expected, actual);
        }
    }
}