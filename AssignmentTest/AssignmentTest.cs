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
            Robot robot = new Robot();

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
            Robot robot = new Robot(ExpectedCommands);

            // Act
            int numCommands = robot.NumCommands;

            // Assert
            Assert.AreEqual(ExpectedCommands, numCommands);
        }

        [TestMethod]
        public void Robot_IsPowered_DefaultValue_IsFalse()
        {
            // Arrange
            Robot robot = new Robot();

            // Act
            bool isPowered = robot.IsPowered;

            // Assert
            Assert.IsFalse(isPowered);
        }

        [TestMethod]
        public void Robot_X_DefaultValue_IsZero()
        {
            // Arrange
            Robot robot = new Robot();

            // Act
            int x = robot.X;

            // Assert
            Assert.AreEqual(0, x);
        }

        [TestMethod]
        public void Robot_Y_DefaultValue_IsZero()
        {
            // Arrange
            Robot robot = new Robot();

            // Act
            int y = robot.Y;

            // Assert
            Assert.AreEqual(0, y);
        }

        [TestMethod]
        public void Robot_SetX_UpdatesXValue()
        {
            // Arrange
            Robot robot = new Robot();

            // Act
            robot.X = -5;

            // Assert
            Assert.AreEqual(-5, robot.X);
        }

        [TestMethod]
        public void Robot_SetY_UpdatesYValue()
        {
            // Arrange
            Robot robot = new Robot();

            // Act
            robot.Y = -5;

            // Assert
            Assert.AreEqual(-5, robot.Y);
        }
    }
}
