namespace Assignment
{
    public interface IRobotCommand
    {
        void Execute(Robot robot);
        void Run(Robot robot);
    }

    public class OffCommand : IRobotCommand
    {
        public static void Run(Robot robot)
        {
            robot.IsPowered = false;
        }

        void IRobotCommand.Execute(Robot robot)
        {
            throw new NotImplementedException();
        }

        void IRobotCommand.Run(Robot robot)
        {
            throw new NotImplementedException();
        }
    }

    public class OnCommand : IRobotCommand
    {
        public static void Run(Robot robot)
        {
            robot.IsPowered = true;
        }

        void IRobotCommand.Execute(Robot robot)
        {
            throw new NotImplementedException();
        }

        void IRobotCommand.Run(Robot robot)
        {
            throw new NotImplementedException();
        }
    }

    public class WestCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            if (robot.IsPowered)
            {
                robot.X--;
            }
        }

        void IRobotCommand.Execute(Robot robot)
        {
            throw new NotImplementedException();
        }

        void IRobotCommand.Run(Robot robot)
        {
            throw new NotImplementedException();
        }
    }

    public class EastCommand : IRobotCommand
    {
        public static void Run(Robot robot)
        {
            if (robot.IsPowered)
            {
                robot.X++;
            }
        }

        void IRobotCommand.Execute(Robot robot)
        {
            throw new NotImplementedException();
        }

        void IRobotCommand.Run(Robot robot)
        {
            throw new NotImplementedException();
        }
    }

    public class SouthCommand : IRobotCommand
    {
        public static void Run(Robot robot)
        {
            if (robot.IsPowered)
            {
                robot.Y--;
            }
        }

        void IRobotCommand.Execute(Robot robot)
        {
            throw new NotImplementedException();
        }

        void IRobotCommand.Run(Robot robot)
        {
            throw new NotImplementedException();
        }
    }

    public class NorthCommand : IRobotCommand
    {
        public static void Run(Robot robot)
        {
            if (robot.IsPowered)
            {
                robot.Y++;
            }
        }

        void IRobotCommand.Execute(Robot robot)
        {
            throw new NotImplementedException();
        }

        void IRobotCommand.Run(Robot robot)
        {
            throw new NotImplementedException();
        }
    }

    // New command class
    /// <summary>
    /// Represents a custom command for the robot.
    /// </summary>
    public class CustomCommand : IRobotCommand
    {
        /// <summary>
        /// Runs the custom command on the robot, performing a specific action.
        /// </summary>
        /// <param name="robot">The robot on which the command will be executed.</param>
        public void Run(Robot robot)
        {
            // Implement the desired action for the custom command
            // For example, let's say the custom command increases the robot's X and Y coordinates by 2
            if (robot.IsPowered)
            {
                robot.X += 2;
                robot.Y += 2;
            }
        }

        void IRobotCommand.Execute(Robot robot)
        {
            throw new NotImplementedException();
        }

        void IRobotCommand.Run(Robot robot)
        {
            throw new NotImplementedException();
        }
    }
}
