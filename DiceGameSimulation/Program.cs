using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace DiceGameSimulation
{
	class Program
	{
		private const int DefaultNumberOfIterations = 1000;
		private const int DefaultNumberOfDice = 5;

		static void Main(string[] args)
		{
			int numberOfIterations;
			int numberOfDice;

			// Getting # of iterations and # of dice from parameter. First parameter is the # of iterations and second is # of dice
			if (args.Length == 2)
			{
				numberOfIterations = int.Parse(args[0]);
				numberOfDice = int.Parse(args[1]);
			}
			else
			{
				numberOfIterations = DefaultNumberOfIterations;
				numberOfDice = DefaultNumberOfDice;
			}
			
			Console.WriteLine("Dice Game Simulation");

			int iterationNumber = 0;

			var finalScores = new Dictionary<int, int>();

			var execTime = Stopwatch.StartNew();
			do
			{
				var game = new DiceGame(numberOfDice);
				var score = game.Run();

				if (finalScores.TryGetValue(score, out int count))
				{
					count++;
					finalScores[score] = count;
				}
				else
				{
					finalScores.Add(score, 1);
				}

				iterationNumber++;
			} while (iterationNumber < numberOfIterations);
			execTime.Stop();

			// Sorting score list to show fianal scores ordered
			var finalScoreList = finalScores.Keys.ToList();
			finalScoreList.Sort();

			Console.WriteLine($"Number of simulations was {iterationNumber} using {numberOfDice} dice.");
			//foreach(KeyValuePair<int, int> score in finalScores)
			foreach (var key in finalScoreList)
			{
				Console.WriteLine($"Total {key} occurred {finalScores[key]} times.");
			}
			Console.WriteLine($"Total simulation took {execTime.Elapsed.TotalSeconds} seconds.");
		}
	}
}
