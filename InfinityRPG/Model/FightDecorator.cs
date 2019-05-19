using InfinityRPG.Interface;

namespace InfinityRPG.Model
{
	public abstract class FightDecorator :IFight
	{
		public abstract void Fight(IFight opponent);
		public string Name { get; }
		public int Hp { get; set; }
		public int Ap { get; set; }
	}
}