using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyIdea
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			var CurrentWorld = new WorldClass();
			var RenderWorld = new Render();
			var Enemy = new EnemyClass();
			var Block = new Block();
			
			int coloumns = 45;//45
			int rows = 20;//20
			string[,] World = new string[coloumns, rows];
			string Player = "I";
			Console.WriteLine("Вы -" + Player);

		start:
			int stepCount = 0;
			string result = "Поражение";
			CurrentWorld.WorldGen(World, coloumns, rows);
			
			
			Block.BlockGen(World, coloumns, rows);
			
			

			//Блок

			int blockPosX = Block.blockPosX;
			int blockPosY = Block.blockPosY;

			//CurrentWorld.EnemySpawn(World, coloumns, rows);
			//Враг
			Enemy.EnemySpawn(World, coloumns, rows);
			int enemyPosX = Enemy.enemyPosX;
			int enemyPosY = Enemy.enemyPosY;

			//Меч
			Random rand = new Random();
			int swordPosX = rand.Next(3, coloumns-1);
			int swordPosY = rand.Next(1, rows-1);
			string Sword = "/";
			World[swordPosX, swordPosY] = Sword;
			//Игрок
			int playerPosX = 3;
			int playerPosY = 2;
			bool isWeaponed = false;
			World[playerPosX, playerPosY] = Player;//Место спавна
			RenderWorld.RenderWorld(World, coloumns, rows);
			while (true)
			{
				Console.WriteLine("Ваше количество шагов: " + stepCount);

				if (World[swordPosX, swordPosY] == World[enemyPosX, enemyPosY])
				{
					Console.Clear();
					goto start;
				}
				if (World[playerPosX, playerPosY] == World[swordPosX, swordPosY])
				{
					Console.WriteLine("Вы нашли меч!");
					isWeaponed = true;
				}
				if (World[playerPosX, playerPosY] == World[enemyPosX, enemyPosY])
				{
					if (!isWeaponed)
					{
						Console.WriteLine("Вы погибли!");
						Console.ReadKey();
						Console.Clear();
						goto start;
						//World[playerPosX, playerPosY] = "-";
						//World[playerPosX = 2, playerPosY = 3] = Player;
					}
					else
					{
						result = "Победа";
						Console.WriteLine("Вы победили врага!");
						

						World[playerPosX, playerPosY] += "-";
						Console.ReadKey();
						Console.Clear();
						goto start;
					}

				}
				if (World[playerPosX, playerPosY] == World[blockPosX, blockPosY])
				{
					Console.WriteLine("Ой мина под кустом, Вы погибли!");
					Console.ReadKey();
					Console.Clear();
					goto start;
				}
				if (World[playerPosX, playerPosY] == World[coloumns-1, playerPosY] || World[playerPosX, playerPosY] == World[0, playerPosY] || World[playerPosX, playerPosY] == World[playerPosX, 0] || World[playerPosX, playerPosY] == World[playerPosX, rows-1])
				{
					
					Console.WriteLine("Вы погибли!");
					Console.Clear();
					goto start;
					//World[playerPosX, playerPosY] = "-";
					//World[playerPosX = 2, playerPosY = 3] = Player;

				}
					Console.WriteLine("Введите сторону движения");
					ConsoleKeyInfo userInput = Console.ReadKey();
					if (userInput.Key == ConsoleKey.D || userInput.Key == ConsoleKey.J)
					{
						
						Console.Clear();
						World[playerPosX, playerPosY] = "-";
						World[playerPosX += 1, playerPosY] = Player;
						RenderWorld.RenderWorld(World, coloumns, rows);
						stepCount += 1;
					}
					if (userInput.Key == ConsoleKey.A || userInput.Key == ConsoleKey.F)
					{

						Console.Clear();
						World[playerPosX, playerPosY] = "-";
						World[playerPosX -= 1, playerPosY] = Player;
						RenderWorld.RenderWorld(World, coloumns, rows);
						stepCount += 1;
					}
					if (userInput.Key == ConsoleKey.W || userInput.Key == ConsoleKey.G)
					{
						Console.Clear();
						World[playerPosX, playerPosY] = "-";
						World[playerPosX, playerPosY -= 1] = Player;
						RenderWorld.RenderWorld(World, coloumns, rows);
						stepCount += 1;
					}
					if (userInput.Key == ConsoleKey.S || userInput.Key == ConsoleKey.H)
					{
						Console.Clear();
						World[playerPosX, playerPosY] = "-";
						World[playerPosX, playerPosY += 1] = Player;
						RenderWorld.RenderWorld(World, coloumns, rows);
						stepCount += 1;
					}
				if (userInput.Key == ConsoleKey.R)
				{
					using (System.IO.StreamWriter sw = new System.IO.StreamWriter(@"C:\Users\kenot\source\repos\CrazyIdea\CrazyIdea\bin\Debug\StepCounts.txt", true))
					{

						sw.WriteLine("Количество шагов: " + stepCount);

						//foreach (char symbol in Alphabet)
						//{
						//	sw.WriteLine(symbol);
						//}

					}
					Console.Clear();
					goto start;
				}
			}
			//Движение вправо
			

			
			
			
		}
		
		
	}
}
