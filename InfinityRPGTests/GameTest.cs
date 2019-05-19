using InfinityRPG;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InfinityRPGTests
{
	[TestClass]
	public class GameTest
	{
		private Player _player;
		private Enemy _enemy;

		[TestMethod]
		public void player_fight_enemy()
		{
			_player = new Player(20, 3);
			_enemy = new Enemy(20, 3);

			_player.Fight(_enemy);

			Assert.AreEqual(17, _enemy.Hp);
		}

		[TestMethod]
		public void enemy_fight_player()
		{
			_player = new Player(20, 3);
			_enemy = new Enemy(20, 3);

			_enemy.Fight(_player);

			Assert.AreEqual(17, _player.Hp);
		}
	}
}