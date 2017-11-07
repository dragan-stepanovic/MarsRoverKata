namespace MarsRover.Tests
{
	public class Rover
	{
		private Position _position;

		public Rover(int x, int y, char direction)
		{
			_position = new Position(x, y, direction);
		}

		public void Explore(string commands)
		{
			_position = new MoveCommands(commands).MoveFrom(_position);
		}

		public bool IsAt(int x, int y)
		{
			return _position.IsAt(x, y);
		}

		public bool IsFacing(char direction)
		{
			return _position.IsFacing(direction);
		}
	}
}