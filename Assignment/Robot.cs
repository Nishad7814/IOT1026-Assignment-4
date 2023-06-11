using System;

namespace Assignment
{
    /// <summary>
    /// Represents a robot that can execute commands.
    /// </summary>
    public class Robot
    {
        /// <summary>
        /// Gets the maximum number of commands the robot can store.
        /// </summary>
        public int NumCommands { get; }

        /// <summary>
        /// Gets or sets the X coordinate of the robot's position.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Gets or sets the Y coordinate of the robot's position.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the robot is powered on or off.
        /// </summary>
        public bool IsPowered { get; set; }

        private readonly IRobotCommand[] _commands;
        private int _commandsLoaded = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="Robot"/> class with the default number of commands (6).
        /// </summary>
        public Robot() : this(6) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Robot"/> class with the specified number of commands.
        /// </summary>
        /// <param name="numCommands">The maximum number of commands the robot can store.</param>
        public Robot(int numCommands)
        {
            _commands = new IRobotCommand[numCommands];
            NumCommands = numCommands;
        }

        /// <summary>
        /// Runs the loaded commands on the robot, displaying the robot's state after each command execution.
        /// </summary>
        public void Run()
        {
            for (var i = 0; i < _commandsLoaded; ++i)
            {
                _commands[i].Execute(this);
                Console.WriteLine(this);
            }
        }

        /// <summary>
        /// Loads a command into the robot.
        /// </summary>
        /// <param name="command">The command to load.</param>
        /// <returns>Returns true if the command was successfully loaded, false otherwise.</returns>
        public bool LoadCommand(IRobotCommand command)
        {
            if (_commandsLoaded >= NumCommands)
                return false;

            _commands[_commandsLoaded++] = command;
            return true;
        }

        /// <summary>
        /// Returns a string representation of the robot's state.
        /// </summary>
        /// <returns>A string representation of the robot's state.</returns>
        public override string ToString()
        {
            return $"[{X} {Y} {IsPowered}]";
        }
    }
}
