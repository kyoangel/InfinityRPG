namespace InfinityRPG
{
	public class TrophyDecorator : FightDecorator
	{
		private readonly IFight _character;
		private readonly ConsoleOutputDecorator _output;

		public TrophyDecorator(IFight character, ConsoleOutputDecorator output)
		{
			_character = character;
			_output = output;
		}

		private void GrantGold(IFight opponent)
		{
			if (_character is Player)
			{
				var player = (_character as Player);
				var enemy = opponent as Enemy;
				if (enemy.Hp <= 0)
				{
					player.Gold += enemy.DropGold;
					_output.GrantGold(player, enemy);
				}
			}
		}

		public override void Fight(IFight opponent)
		{
			_character.Fight(opponent);
			GrantGold(opponent);
		}
	}
}