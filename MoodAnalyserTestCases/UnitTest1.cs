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
            moodanalyser = new MoodAnalyser();
            string Message = "I Am In a Sad Mood";
            //act
            string result = moodanalyser.AnalyserMoodwithconstructor(Message);
            //assert
            Assert.AreEqual("SAD", result);


        }
        [Test]
        public void GivenMessage_WhenSad_ShouldReturnHappy_DefaultConstructor()
        {
            moodanalyser = new MoodAnalyser();
            string Message = "I Am In Happy Mood";
            string result = moodanalyser.AnalyserMoodwithconstructor(Message);
            Assert.AreEqual("HAPPY", result);
        }
    }
}