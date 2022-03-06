using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{    
    public class Program
    {       
        public static void Main(string[] args)
        {            
            Console.WriteLine("Welcome To Mood Analyser Program");

            MoodAnalyzerClass mood = new MoodAnalyzerClass("I am in sad mood");
            string result = mood.AnalyseMood();
            Console.WriteLine("The mood is {0}", result);
        }
    }
}