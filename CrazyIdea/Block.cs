using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyIdea
{
	public class Block
	{
		public int blockPosX;
		public int blockPosY;
		public string blockName;
		public Block() { }
		public void BlockGen(string[,] World, int coloumns, int rows)
		{
			
			Random rand = new Random();
			for (int i = 0 ; i < coloumns/4; i++)
				{
				
				string blockName = "N";
				blockPosX = rand.Next(4, coloumns-1);
				blockPosY = rand.Next(4, rows-1);
				
				World[blockPosX, blockPosY] = blockName;
				}
				
				
			
			
			
				//Console.WriteLine(blockPosX);
				//Console.WriteLine(blockPosY);
			





		}
	}
}
