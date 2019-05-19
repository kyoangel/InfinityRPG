namespace InfinityRPG
{
	public abstract class FightDecorator :IFight
	{
		public abstract void Fight(IFight opponent);
		public string Name { get; }
		public int Hp { get; set; }
		public int Ap { get; set; }
	}
}