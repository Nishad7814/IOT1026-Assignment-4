using System;

namespace Assignment
{
    /// <summary>
    /// Represents a simple robot tester class.
    /// </summary>
    public static class RobotTester
    {
        /// <summary>
        /// Tests the robot by assigning and running commands.
        /// </summary>
        public static void TestRobot()
        {
            // Create a new instance of the Robot class
            Robot newRobot = new();

            // Display available commands to the user
            Console.WriteLine("Give 6 commands to the robot. Possible commands are:");
            Console.WriteLine("on, off, north, south, east, west");

            int input = 0;
            while (input < 6)
            {
                Console.Write($"Assign command #{input + 1}: ");
                bool commandAdded = AssignCommand(newRobot, Console.ReadLine());
                if (commandAdded)
                {
                    input++;
                }
            }

            // Run the robot
            newRobot.Run();
        }

        /// <summary>
        /// Assigns a command to the robot based on the user input.
        /// </summary>
        /// <param name="robot">The Robot object.</param>
        /// <param name="command">The user input representing the command.</param>
        /// <returns>True if the command was added successfully, false otherwise.</returns>
        private static bool AssignCommand(Robot robot, string? command)
        {
            switch (command)
            {
                case "on":
                    robot.LoadCommand(new OnCommand());
                    return true;
                case "off":
                    robot.LoadCommand(new OffCommand());
                    return true;
                case "north":
                    robot.LoadCommand(new NorthCommand());
                    return true;
                case "south":
                    robot.LoadCommand(new SouthCommand());
                    return true;
                case "east":
                    robot.LoadCommand(new EastCommand());
                    return true;
                case "west":
                    robot.LoadCommand(new WestCommand());
                    return true;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid command - Try again");
                    Console.ResetColor();
                    return false;
            }
        }
    }
}
