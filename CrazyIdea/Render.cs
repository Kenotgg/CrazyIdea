using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyIdea
{
	public class Render
	{
		public void RenderWorld(string[,] World, int coloumns, int rows)
		{
			for (int a = 0; a < rows; a++)//Отрисовка мира
			{
				for (int b = 0; b < coloumns; b++)
				{
					Console.Write(World[b, a]);
				}
				Console.WriteLine();
			}
		}
	}
}
