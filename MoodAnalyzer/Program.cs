using System;

namespace MoodAnalyzer
{    
    public class Program
    {        
        public static void Main(string[] args)
        {            
            Console.WriteLine("Welcome To Mood Analyser Program");

            //Calling the mood analyser object(UC1)
            MoodAnalyzerClass mood = new MoodAnalyzerClass();
            string result = mood.AnalyseMood("I am in any mood");

            Console.WriteLine("The mood is {0}", result);           
        }
    }
}