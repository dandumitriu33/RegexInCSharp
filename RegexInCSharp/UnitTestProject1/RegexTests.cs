using System;
using System.Windows;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexInCSharp;

namespace UnitTestProject1
{
    [TestClass]
    public class RegexTests
    {
        [TestMethod]
        public void NameValidTest()
        {
            // Arrange
            string name = "Tim Corey";
            string name2 = "Chok aTar";
            MainWindow testMainWindow = new MainWindow();
            bool expected = true;
            bool expected2 = true;

            // Act
            bool result = testMainWindow.ValidName(name);
            bool result2 = testMainWindow.ValidName(name2);

            // Assert
            Assert.AreEqual(expected, result);
            Assert.AreEqual(expected2, result2);
        }

        [TestMethod]
        public void PhoneValidTest()
        {
            // Arrange
            string number = "123 222 3434";
            string number2 = "(123) 222 3333";
            MainWindow testMainWindow = new MainWindow();
            bool expected = true;
            bool expected2 = true;

            // Act
            bool result = testMainWindow.ValidPhone(number);
            bool result2 = testMainWindow.ValidPhone(number2);

            // Assert
            Assert.AreEqual(expected, result);
            Assert.AreEqual(expected2, result2);
        }

        [TestMethod]
        public void EmailValidTest()
        {
            // Arrange
            string email = "geaorge@email.com";
            string email2 = "212G@email.co.uk";
            MainWindow testMainWindow = new MainWindow();
            bool expected = true;
            bool expected2 = true;

            // Act
            bool result = testMainWindow.ValidEmail(email);
            bool result2 = testMainWindow.ValidEmail(email2);

            // Assert
            Assert.AreEqual(expected, result);
            Assert.AreEqual(expected2, result2);
        }
    }
}
