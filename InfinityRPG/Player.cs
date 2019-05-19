namespace InfinityRPG
{
	public class Player : Character, IFight
	{
		public Player(int hp, int ap) :base(hp,ap)
		{
		}


		public void Fight(Character enemy)
		{
			enemy.Hp -= Ap;
		}
	}
}