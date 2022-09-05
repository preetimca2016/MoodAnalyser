using System;

namespace MoodAnalyserTestCases
{
    public class Tests
    {
        MoodAnalyser moodanalyser;

        [SetUp]
        public void Setup()
        {
            moodanalyser = new MoodAnalyser();
        }

        [Test]
        public void GivenMessage_WhenSad_ShouldReturnSad_DefaultConstructor()
        {
            //arrange
            MoodAnalyser moodanalyser = new MoodAnalyser();
            string Message = "I Am In a Sad Mood";
            //act
            string result = moodanalyser.AnalyserMoodwithconstructor(Message);
            //assert
            Assert.AreEqual("SAD", result);
        }
        [Test]
        public void GivenMessage_WhenSad_ShouldReturnHappy_DefaultConstructor()
        {
            MoodAnalyser moodanalyser = new MoodAnalyser();
            string Message = "I Am In Happy Mood";
            string result = moodanalyser.AnalyserMoodwithconstructor(Message);
            Assert.AreEqual("HAPPY", result);
        }
        [Test]
        public void GivenMessage_WhenSad_ShouldReturnSadParameterisedConstructor()
        {
            MoodAnalyser moodanalyser = new MoodAnalyser();
            string Message = "I am in Sad Mood";
            string result = moodanalyser.AnalyserMoodwithparameterizedconstructor(Message);
            Assert.AreEqual("SAD", result);
        }
        [Test]
        public void GivenMessage_WhenSad_ShouldReturnHappyParameterisedConstructor()
        {
            MoodAnalyser moodanalyser = new MoodAnalyser();
            string Message = "I am in Happy Mood";
            string result = moodanalyser.AnalyserMoodwithparameterizedconstructor(Message);
            Assert.AreEqual("HAPPY", result);
        }
         //UC2:Handle Null exception
        [Test]
        public void GivenMessage_WhenHappy_ShouldReturnHappy()
        {
            moodanalyser = new MoodAnalyser();
            string Message = "I am in Happy Mood";
            string result = moodanalyser.AnalyseMoodReturnHappy(Message);
            Assert.AreEqual("HAPPY", result);
        }
    }
}
