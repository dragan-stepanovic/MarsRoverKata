using System.Linq;

namespace MarsRover.Tests
{
	public class MoveCommands
	{
		private readonly string _commands;

		public MoveCommands(string commandsAsString)
		{
			if (commandsAsString == null)
				throw new InvalidCommandException();

			commandsAsString = commandsAsString.ToUpper();
			if (commandsAsString.Any(IsNotValid))
				throw new InvalidCommandException();

			_commands = commandsAsString;
		}

		public Position MoveFrom(Position position)
		{
			foreach (var command in _commands)
			{
				if (command == 'F')
					position = new MoveForwardCommand().MoveFrom(position);
				else if (command == 'B')
					position = new MoveBackwardsCommand().MoveFrom(position);
				else if (command == 'L')
					position = new TurnLeftCommand().TurnFrom(position);
				else if (command == 'R')
					position = new TurnRightCommand().TurnFrom(position);
			}

			return position;
		}

		private bool IsNotValid(char command)
		{
			return !IsValidCommand(command);
		}

		private bool IsValidCommand(char command)
		{
			return command == 'F'
			       || command == 'B'
			       || command == 'L'
			       || command == 'R';
		}
	}
}