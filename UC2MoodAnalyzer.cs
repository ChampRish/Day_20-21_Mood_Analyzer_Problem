using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC2ExceptionMoodAnalyzer
{
    public class UC2MoodAnalyzer
    {
        private string message;
        public UC2MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyserMood()
        {
            try
            {
                if (this.message.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch
            {
                return "Happy";
            }
            Console.ReadLine();


        }
    }
}
