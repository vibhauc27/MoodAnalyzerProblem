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
            try
            {
                string mood = String.Empty;
                MoodAnalyzerClass moodAnalyser = new MoodAnalyzerClass();
                string result = moodAnalyser.AnalyseMood(mood);
                Console.WriteLine(result);
            }
            catch (MoodAnalyzerCustomException m)
            {
                Console.WriteLine(m.Message);
            }
        }
    }
}