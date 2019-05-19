using System;

namespace InfinityRPG
{
	public class Enemy : Character
	{
		private static int _lv = 1;
		public Enemy(string name, int hp, int ap) : base(name, hp, ap)
		{
			_lv += 1;
		}

		public int DropGold => (_lv * new Random(Guid.NewGuid().GetHashCode()).Next(100,200)) / 100;
	}
}