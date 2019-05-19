using System;

namespace InfinityRPG
{
	public class ConsoleOutputDecorator : FightDecorator
	{
		private readonly IFight _character;

		public ConsoleOutputDecorator(IFight character)
		{
			_character = character;
		}

		private void ConsoleFight(IFight opponent)
		{
			Console.WriteLine($"{_character.Name} {nameof(opponent.Fight)} {opponent.Name} deals {_character.Ap} point damage");
		}

		public override void Fight(IFight opponent)
		{
			ConsoleFight(opponent);
			_character.Fight(opponent);
		}

		public void GrantGold(Player player, Enemy enemy)
		{
			Console.WriteLine($"{player.Name} grant {enemy.DropGold} golds");
		}
	}
}