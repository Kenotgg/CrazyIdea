using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyIdea
{
	public class WorldClass
	{
		 
		public WorldClass() 
		{ 

		}
		public void WorldGen(string[,] World,int coloumns,int rows)
		{
			for (int i = 0; i < rows; i++)//Генерация мира
			{
				for (int j = 0; j < coloumns; j++)
				{
					World[j, i] = "-";
				}
			}
		}
		

	}
}
