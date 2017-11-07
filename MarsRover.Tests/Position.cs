namespace MarsRover.Tests
{
	public class Position
	{
		private readonly int _x;
		private readonly int _y;
		public char Direction { get; }

		public Position(int x, int y, char direction)
		{
			if (!IsValidDirection(direction))
				throw new InvalidDirectionException();

			_x = x;
			_y = y;
			Direction = direction;
		}

		private static bool IsValidDirection(char direction)
		{
			var directionAsCapital = direction.ToString().ToUpper();

			return directionAsCapital == "N"
				   || directionAsCapital == "S"
				   || directionAsCapital == "W"
				   || directionAsCapital == "E";
		}

		public bool IsAt(int x, int y)
		{
			return _x == x && _y == y;
		}

		public bool IsFacing(char direction)
		{
			var directionAsCapital = direction.ToString().ToUpper();
			return Direction.ToString() == directionAsCapital;
		}

		public Position Increment(int dx, int dy)
		{
			return new Position(_x + dx, _y + dy, Direction);
		}

		public Position Face(char direction)
		{
			return new Position(_x, _y, direction);
		}
	}
}