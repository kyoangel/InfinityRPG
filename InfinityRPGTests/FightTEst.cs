using InfinityRPG;
using InfinityRPG.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InfinityRPGTests
{
	[TestClass]
	public class FightTest
	{
		private Player _player;
		private Enemy _enemy;

		[TestInitialize]
		public void Init()
		{
			_player = new Player("Hero",20, 3);
			_enemy = new Enemy("Creep",20, 3);
		}
		[TestMethod]
		public void player_fight_enemy()
		{

			_player.Fight(_enemy);

			Assert.AreEqual(17, _enemy.Hp);
		}

		[TestMethod]
		public void enemy_fight_player()
		{

			_enemy.Fight(_player);

			Assert.AreEqual(17, _player.Hp);
		}
	}
}