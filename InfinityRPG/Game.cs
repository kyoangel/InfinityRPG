using System;

namespace InfinityRPG
{
	public class Game
	{
		public void Run()
		{
			var player = new Player(20, 3);
			var enemy = new Enemy(20, 3);

			if (player.Hp > 0 )
			{
				if (enemy.Hp > 0)
				{
					
				player.Fight(enemy);
				enemy.Fight(player);
				}
				else
				{
					enemy = new Enemy(20,3);
				}
			}

			Console.WriteLine("End");
			Console.ReadLine();
		}
	}
}