using InfinityRPG.Interface;

namespace InfinityRPG.Model
{
	public class Character : IFight
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

		public void Fight(IFight opponent)
		{
			opponent.Hp -= Ap;
		}
	}
}