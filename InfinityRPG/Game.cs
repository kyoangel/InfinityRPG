using System;

namespace InfinityRPG
{
	public class Game
	{
		public void Run()
		{
			var player = new Player("Hero", 20, 3);
			var consolePlayer = new ConsoleOutputDecorator(player);
			var trophyPlayer = new TrophyDecorator(consolePlayer, consolePlayer);
			var enemy = new Enemy("Creep", 20, 3);
			var consoleEnemy = new ConsoleOutputDecorator(enemy);
			var trophyEnemy = new TrophyDecorator(consoleEnemy, consoleEnemy);

			while (player.Hp > 0)
			{
				if (enemy.Hp > 0)
				{
					trophyPlayer.Fight(enemy);
					trophyEnemy.Fight(player);
				}
				else
				{
					enemy = new Enemy("Creep", 20, 3);
				}
			}

			Console.WriteLine("End");
			Console.ReadLine();
		}
	}
}