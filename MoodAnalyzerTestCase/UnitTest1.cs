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
            string msg = "I am in any Mood";
            MoodAnalyzerClass mood = new MoodAnalyzerClass();
            string expected = "happy";

            ///Act
            string actual = mood.AnalyseMood(msg);

            ///Asert
            Assert.AreEqual(expected, actual);
        }
    }
}