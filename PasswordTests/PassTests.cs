using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Password;

namespace PasswordTests
{
    [TestClass]
    public class PassTests
    {
        [TestMethod]
        public void GetPasswordStrength_AllCahrs_1Points()
        {
            // Arrange
            Pass pass = new Pass("password");
            // Act
            int score = pass.Score;
            // Assert
            Assert.AreEqual(1, score);
        }

        [TestMethod]
        public void GetPasswordStrength_AllCahrs_2Points()
        {
            // Arrange
            Pass pass = new Pass("password1");
            // Act
            int score = pass.Score;
            // Assert
            Assert.AreEqual(2, score);
        }

        [TestMethod]
        public void GetPasswordStrength_AllCahrs_3Points()
        {
            // Arrange
            Pass pass = new Pass("Password1");
            // Act
            int score = pass.Score;
            // Assert
            Assert.AreEqual(3, score);
        }

        [TestMethod]
        public void GetPasswordStrength_AllCahrs_4Points()
        {
            // Arrange
            Pass pass = new Pass("Pass1@word"); // Заглавная, строчная, цифра, спец. символ
            // Act
            int score = pass.Score;
            // Assert
            Assert.AreEqual(4, score);
        }

        [TestMethod]
        public void GetPasswordStrength_AllCahrs_5Points()
        {
            // Arrange
            Pass pass = new Pass("Password123!"); // Более 10 символов, все условия выполнены
            // Act
            int score = pass.Score;
            // Assert
            Assert.AreEqual(5, score);
        }

        [TestMethod]
        public void GetPasswordStrength_AllCahrs_0Points()
        {
            // Arrange
            Pass pass = new Pass(""); // Не соответствует ни одному критерию
            // Act
            int score = pass.Score;
            // Assert
            Assert.AreEqual(0, score);
        }


    }
}
    