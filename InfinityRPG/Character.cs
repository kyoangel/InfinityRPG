using System;

namespace InfinityRPG
{
	public abstract class Character : IFight
	{
		public string Name { get; }
		public int Hp { get; set; }
		public int Ap { get; set; }

		protected Character(string name, int hp, int ap)
		{
			Name = name;
			Hp = hp;
			Ap = ap;
		}

		public void Fight(Character opponent)
		{
			ConsoleFight(opponent);
			opponent.Hp -= Ap;

			if (this is Player)
			{
				var player = (this as Player);
				var enemy = opponent as Enemy;
				if (enemy.Hp <= 0)
				{
					player.Gold += enemy.DropGold;
					Console.WriteLine($"{player.Name} grant {enemy.DropGold} golds");
				}
			}
		}

		private void ConsoleFight(Character opponent)
		{
			Console.WriteLine($"{Name} {nameof(Fight)} {opponent.Name} deals {Ap} point damage");
		}
	}
}