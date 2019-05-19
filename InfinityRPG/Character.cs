namespace InfinityRPG
{
	public abstract class Character
	{
		public int Hp { get; set; }
		public int Ap { get; set; }

		protected Character(int hp, int ap)
		{
			Hp = hp;
			Ap = ap;
		}
	}
}