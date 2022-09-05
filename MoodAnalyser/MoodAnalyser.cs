using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserTestCases
{
    public class MoodAnalyser
    {
        public string Message;
        public MoodAnalyser()
        {

        }
        public MoodAnalyser(string Message)
        {
            this.Message = Message;
        }
        public string AnalyserMoodwithconstructor(string Message)
        {
            if (Message.ToLower().Contains("sad"))
            {
                return "SAD";

            }
            else
            {
                return "HAPPY";
            }
        }
        public string AnalyserMoodwithparameterizedconstructor(string Message)
        {
            if (Message.ToLower().Contains("sad"))
            {
                return "SAD";

            }
            else
            {
                return "HAPPY";
            }
        } 
        public string AnalyseMoodReturnHappy(string Message)
        {
            try
            {
                if (Message.ToLower().Contains("sad"))
                    return "SAD";

                else
                    return "HAPPY";
            }
            catch (NullReferenceException)
            {
                return "HAPPY";
            }
        }
    }
}
