using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InteractiveKWIC_Test
{
    [TestClass]
    public class InteractiveKWIC_UnitTest
    {
        [TestMethod]
        public void TestPunctuation_1()
        {
            String inputValue = "Ah, Wilderness!";
            String expectedOutput = "Ah, Wilderness!\n";
            expectedOutput +=       "Wilderness! Ah,";
        }

        [TestMethod]
        public void TestPunctuation_2()
        {
            String inputValue = "AC/DC The Complete Guide";
            String expectedOutput = "AC/DC The Complete Guide\n";
            expectedOutput +=       "Complete Guide AC/DC The\n";
            expectedOutput +=       "Guide AC/DC The Complete\n";
            expectedOutput +=       "The Complete Guide AC/DC";
        }

        [TestMethod]
        public void TestPunctuation_3() 
        {
            String inputValue = "AC / DC The Complete Guide";   
            String expectedOutput = "AC / DC The Complete Guide\n";
            expectedOutput += "Complete Guide AC / DC The\n";
            expectedOutput += "DC The Complete Guide AC /\n";
            expectedOutput += "Guide AC / DC The Complete Guide\n";
            expectedOutput += "The Complete Guide AC / DC\n";
            expectedOutput += "/ DC The Complete Guide AC";
        }

        [TestMethod]
        public void TestPunctuation_4()
        {
            String inputValue = "!@#$%^&*()<>?,./;':{}[]";
            String expectedOutput = "!@#$%^&*()<>?,./;':{}[]";
        }
    }
}