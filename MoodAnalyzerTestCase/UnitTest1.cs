using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MoodAnalyzerTestCase
{
    [TestClass]
    public class UnitTest1
    {
        //TC-1.1
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

        //TC-1.2
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

        //TC-3.1

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

        //TC-3.2

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

        //Method to test Mood analyzer object UC4 - TC 4.1
        [TestMethod]
        public void Given_MoodAnalyser_ClassName_Should_Return_MoodAnalyser_Object()
        {
            //Arrange
            string message = null;
            object expected = new MoodAnalyzerClass(message); 
            
            //Act
            object Obj = MoodAnalyserFactoryClass.CreateMoodAnalyserObject("MoodAnalyzer.MoodAnalyzerClass", "MoodAnalyzerClass");
            
            //Assert
            expected.Equals(Obj);
        }

        //TC-4.2

        [TestMethod]
        public void Given_Improper_Class_Name_Should_Throw_MoodAnalysisException_Indicating_No_Such_Class()
        {
            try
            {
                //Arrange
                string className = "WrongNamespace.MoodAnalyser";
                string constructorName = "MoodAnalyser";

                //Act
                object resultObj = MoodAnalyserFactoryClass.CreateMoodAnalyserObject(className, constructorName);
            }
            catch (MoodAnalyzerCustomException e)
            {
                //Assert
                Assert.AreEqual("class not found", e.Message);
            }
        }

        //TC-4.3

        [TestMethod]
        public void Given_Improper_Constructor_Name_Should_Throw_MoodAnalysisException_Indicating_No_Such_Constructor()
        {
            try
            {
                //Arrange
                string className = "MoodAnalyzerProblem.MoodAnalyser";
                string constructorName = "WrongConstructorName";

                //Act
                object resultObj = MoodAnalyserFactoryClass.CreateMoodAnalyserObject(className, constructorName);
            }
            catch (MoodAnalyzerCustomException e)
            {
                //Assert
                Assert.AreEqual("constructor not found", e.Message);
            }
        }

        //TC-5.1 Given proper MoodAnalyser Class Name Should Return MoodAnalyser Object Using Parametrized Constructor

        [TestMethod]
        public void Given_MoodAnalyser_Class_Name_Should_Return_MoodAnalyser_Object_Using_Parametrized_Constructor()
        {

            //Arrange
            string className = "MoodAnalyzer.MoodAnalyzerClass";
            string constructorName = "MoodAnalyzerClass";
            MoodAnalyzerClass expectedObj = new MoodAnalyzerClass("HAPPY");

            //Act
            object resultObj = MoodAnalyserFactoryClass.CreateMoodAnalyzerObjectUsingParameterizedConstructor(className, constructorName);
           
            //Assert
            expectedObj.Equals(resultObj);
        }

        //TC-5.2 Given Improper MoodAnalyser Class Name Should throw MoodAnalysisException for Parametrized Constructor


        [TestMethod]
        public void Given_Improper_Class_Name_Should_Throw_MoodAnalysisException_For_Parameterized_Constructor()
        {
            try
            {
                //Arrange
                string className = "WrongNameSpace.MoodAnalyzer";
                string constructorName = "MoodAnalyzer";
                MoodAnalyzerClass expectedObj = new MoodAnalyzerClass("HAPPY");
                //Act
                object resultObj = MoodAnalyserFactoryClass.CreateMoodAnalyzerObjectUsingParameterizedConstructor(className, constructorName);
            }
            catch (MoodAnalyzerCustomException e)
            {
                //Assert
                Assert.AreEqual("class not found", e.Message);
            }
        }

        //TC-5.3 Given Improper Constructor Name Should throw MoodAnalysisException for Parametrized Constructor


        [TestMethod]
        public void Given_Improper_Constructor_Name_Should_Throw_MoodAnalysisException_For_Parameterized_Constructor()
        {
            try
            {
                //Arrange
                string className = "MoodAnalyzer.MoodAnalyzerClass";
                string constructorName = "WrongConstructorName";
                MoodAnalyzerClass expectedObj = new MoodAnalyzerClass("HAPPY");
                
                //Act
                object resultObj = MoodAnalyserFactoryClass.CreateMoodAnalyzerObjectUsingParameterizedConstructor(className, constructorName);
            }
            catch (MoodAnalyzerCustomException e)
            {
                //Assert
                Assert.AreEqual("constructor not found", e.Message);
            }
        }
    }
}
    
