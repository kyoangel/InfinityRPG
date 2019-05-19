using System;

namespace InfinityRPG
{
	public class Game
	{
		public void Run()
		{
			var player = new Player("Hero", 20, 3);
			var enemy = new Enemy("Creep", 20, 3);

			while (player.Hp > 0)
			{
				if (enemy.Hp > 0)
				{
					player.Fight(enemy);
					enemy.Fight(player);
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