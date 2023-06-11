using System;

namespace Assignment
{
    public static class RobotTester
    {
        public static void TestRobot()
        {
            Robot newRobot = new();
            Console.WriteLine("Give 6 commands to the robot. Possible commands are:");
            Console.WriteLine("on, off, north, south, east, west");

            for (int input = 0; input < 6; input++)
            {
                Console.Write($"Assign command #{input + 1}: ");
                bool commandAdded = AssignCommand(newRobot, Console.ReadLine());
                if (!commandAdded)
                {
                    input--;
                }
            }

            newRobot.Run();
        }

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
