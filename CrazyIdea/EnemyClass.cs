using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyIdea
{
	public class EnemyClass
	{
		public int enemyPosX;
		public int enemyPosY;
		public EnemyClass() 
		{
			
		}
		public void EnemySpawn(string[,] World, int coloumns,int rows)
		{
			
			string enemyName = "E";
			Random randEnemySpawn = new Random();
			enemyPosX = randEnemySpawn.Next(4, coloumns-2);
			enemyPosY = randEnemySpawn.Next(3, rows-2);
			World[enemyPosX, enemyPosY] = enemyName;
			
		}
		

	}
}
