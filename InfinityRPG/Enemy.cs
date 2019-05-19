namespace InfinityRPG
{
	public class Enemy : Character, IFight
	{
		public Enemy(int hp, int ap) : base(hp, ap)
		{
		}

		public void Fight(Character player)
		{
			player.Hp -= Ap;
		}
	}
}