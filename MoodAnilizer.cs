using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_Day20
{
    public class MoodAnilizer
    {
        private string message;
        public MoodAnilizer(string message)
        {
            this.message = message;
        }
        public string AnalyserMood()
        {
            if (this.message.Contains("SAD"))
            {
                return "SAD";
            }
            else
            {
                return "Happy";
            }
        }
    }
}
