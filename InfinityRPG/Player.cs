namespace InfinityRPG
{
	public class Player : Character
	{
		public Player(string name, int hp, int ap) :base(name, hp,ap)
		{
		}

		public int Gold { get; set; }
	}
}