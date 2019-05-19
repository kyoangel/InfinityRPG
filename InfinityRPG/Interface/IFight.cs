namespace InfinityRPG.Interface
{
	public interface IFight
	{
		void Fight(IFight opponent);
		string Name { get; }
		int Hp { get; set; }
		int Ap { get; set; }
	}
}