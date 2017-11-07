namespace MarsRover.Tests
{
	public class TurnLeftCommand
	{
		public Position TurnFrom(Position position)
		{
			var direction = position.Direction;

			if (position.Direction == 'S')
				direction = 'E';
			else if (position.Direction == 'E')
				direction = 'N';
			else if (position.Direction == 'N')
				direction = 'W';
			else if (position.Direction == 'W')
				direction = 'S';

			return position.Face(direction);
		}
	}
}