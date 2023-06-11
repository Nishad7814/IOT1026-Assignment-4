using Assignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssignmentTest
{
    [TestClass]
    public class RobotTests
    {
        [TestMethod]
        public void DefaultRobot_NumCommands_InitializedTo6()
        {
            // Arrange
            Robot robot = new();

            // Act
            int numCommands = robot.NumCommands;

            // Assert
            Assert.AreEqual(6, numCommands);
        }

        [TestMethod]
        public void CustomRobot_NumCommands_InitializedToSpecifiedValue()
        {
            // Arrange
            const int ExpectedCommands = 10;
            Robot robot = new(ExpectedCommands);

            // Act
            int numCommands = robot.NumCommands;

            // Assert
            Assert.AreEqual(ExpectedCommands, numCommands);
        }

        [TestMethod]
        public void Robot_IsPowered_DefaultValue_IsFalse()
        {
            // Arrange
            Robot robot = new();

            // Act
            bool isPowered = robot.IsPowered;

            // Assert
            Assert.IsFalse(isPowered);
        }

        [TestMethod]
        public void Robot_X_DefaultValue_IsZero()
        {
            // Arrange
            Robot robot = new();

            // Act
            int x = robot.X;

            // Assert
            Assert.AreEqual(0, x);
        }

        [TestMethod]
        public void Robot_Y_DefaultValue_IsZero()
        {
            // Arrange
            Robot robot = new();

            // Act
            int y = robot.Y;

            // Assert
            Assert.AreEqual(0, y);
        }

        [TestMethod]
        public void Robot_SetX_UpdateXValue()
        {
            // Arrange
            Robot robot = new()
            {
                // Act
                X = -5
            };

            // Assert
            Assert.AreEqual(-5, robot.X);
        }

        [TestMethod]
        public void Robot_SetY_UpdateYValue()
        {
            // Arrange
            Robot robot = new()
            {
                // Act
                Y = -5
            };

            // Assert
            Assert.AreEqual(-5, robot.Y);
        }
    }
}
