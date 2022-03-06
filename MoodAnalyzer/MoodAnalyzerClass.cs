using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{   
    public class MoodAnalyzerClass
    {
        //Declaring varibale
        public string message;

        //Constructor to initialize message 
        public MoodAnalyzerClass(string message)
        {
            this.message = message;
        }

        //Method to analyse the mood from  the given message
        public string AnalyseMood()
        {
            //Handling exception if user provide null value(UC2)
            try
            {
                if (message.ToLower().Contains("sad"))
                {
                    return "sad";
                }
                else
                {
                    return "happy";
                }
            }
            catch (NullReferenceException)
            {
                return "happy";
            }
        }
    }
}