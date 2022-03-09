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
            MoodAnalyzerClass mood = new MoodAnalyzerClass();
            string expected = "sad";

            //Act
            string actual = mood.AnalyseMood(msg);

            //Asert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenAnyMessage_ReturnHappyMood()
        {
            //Arange
            string msg = "I am in any Mood";
            MoodAnalyzerClass mood = new MoodAnalyzerClass();
            string expected = "happy";

            //Act
            string actual = mood.AnalyseMood(msg);

            //Asert
            Assert.AreEqual(expected, actual);
        }

        //Method to test happy message(UC2-TC2.1)
        [TestMethod]
        public void GivenNullMessageException()
        {
            
            //Arange
            string msg = null;
            string expected = "happy";
            MoodAnalyzerClass mood = new MoodAnalyzerClass();

            //Act
            string actual = mood.AnalyseMood(msg);

            //Asert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenNullMood_ShouldReturn_NULL_MOOD_EXCEPTION()
        {

            //Arange
            string moodMessage = null;
            string expected = "Null message passed";
            MoodAnalyzerClass mood = new MoodAnalyzerClass();

            //Act
            string actual = mood.AnalyseMood(moodMessage);

            //Asert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenEmptyMood_ShouldReturn_EMPTY_MOOD_EXCEPTION()
        {

            //Arange
            string moodMessage = string.Empty;
            string expected = "Empty message passed";
            MoodAnalyzerClass mood = new MoodAnalyzerClass();

            //Act
            string actual = mood.AnalyseMood(moodMessage);

            //Asert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Given_MoodAnalyser_ClassName_Should_Return_MoodAnalyser_Object1()
        {
            //Arrange
            string message = null;
            object expected = new MoodAnalyzerClass(message); 
            
            //Act
            object Obj = MoodAnalyserFactoryClass.CreateMoodAnalyserObject("MoodAnalyzer.MoodAnalyzerClass", "MoodAnalyzerClass");
            
            //Assert
            expected.Equals(Obj);
        }
        
    }
}