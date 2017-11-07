namespace MarsRover.Tests
{
	public class TurnRightCommand
	{
		public Position TurnFrom(Position position)
		{
			var direction = position.Direction;

			if (position.Direction == 'S')
				direction = 'W';
			else if (position.Direction == 'W')
				direction = 'N';
			else if (position.Direction == 'N')
				direction = 'E';
			else if (position.Direction == 'E')
				direction = 'S';

			return position.Face(direction);
		}
	}
}