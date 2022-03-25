using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest_Day20;

namespace Unittest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string expection = "SAD";
            string message = "I am in SAD Mood";
            MoodAnilizer moodanilizer = new MoodAnilizer(message);

            //Act
            string mood = moodanilizer.AnalyserMood();

            //Assert
            Assert.AreEqual(expection, mood);
        }
    }
}