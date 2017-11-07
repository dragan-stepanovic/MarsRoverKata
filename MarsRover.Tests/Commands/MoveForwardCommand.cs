namespace MarsRover.Tests
{
	public class MoveForwardCommand
	{
		public Position MoveFrom(Position position)
		{
			var dy = 0;
			var dx = 0;

			if (position.Direction == 'E')
				dx = 1;
			else if (position.Direction == 'W')
				dx = -1;
			else if (position.Direction == 'N')
				dy = 1;
			else if (position.Direction == 'S')
				dy = -1;

			return position.Increment(dx, dy);
		}
	}
}