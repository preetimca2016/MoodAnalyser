//using MoodAnalyserTest;
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
        // TC 1.1: Given message "I am in SAD Mood " return the "SAD"
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
        //TC 1.2: Given message "I am in HAPPY Mood " return the "HAPPY"
        [Test]
        public void GivenMessage_WhenSad_ShouldReturnHappy_DefaultConstructor()
        {
            moodanalyser = new MoodAnalyser();
            string Message = "I Am In Happy Mood";
            string result = moodanalyser.AnalyserMoodwithconstructor(Message);
            Assert.AreEqual("HAPPY", result);
        }
        // TC 1.1:Refactor With Parameterised constructor Given message "I am in SAD Mood " return the "SAD"
        [Test]
        public void GivenMessage_WhenSad_ShouldReturnSadParameterisedConstructor()
        {
            moodanalyser = new MoodAnalyser();
            string Message = "I am in Sad Mood";
            string result = moodanalyser.AnalyserMoodwithparameterizedconstructor(Message);
            Assert.AreEqual("SAD", result);
        }
        //TC 1.2: REfactor Parameterised constructorGiven message "I am in HAPPY Mood " return the "HAPPY"
        [Test]
        public void GivenMessage_WhenSad_ShouldReturnHappyParameterisedConstructor()
        {
            moodanalyser = new MoodAnalyser();
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

        // TU3.1 Given Null mood should throw moodAnalyser exception
        [Test]
        public void GivenMessage_WhenNull_UsingCustomException_ShouldReturnNullMood()
        {
            moodanalyser = new MoodAnalyser();
            try
            {
                string Message = moodanalyser.AnalyseMood();
            }
            catch (MoodAnalyserTestCases.MoodAnalyserException exception)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.NULL_MOOD, exception.exceptionType);
            }
        }
        
        [Test]
        public void GivenMessage_WhenEmpty_UsingCustomException_ShouldReturnEmptyMood()
        {
            moodanalyser = new MoodAnalyser("");
            try
            {
                string Message = moodanalyser.AnalyseMood();
            }
            catch (MoodAnalyserException exception)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.EMPTY_MOOD, exception.exceptionType);

            }
        }
    }
}