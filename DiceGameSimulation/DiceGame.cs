using System.Collections.Generic;
using System.Linq;

namespace DiceGameSimulation
{
	public class DiceGame
	{
		private readonly int startingNumberOfDice;

		public DiceGame(int numberOfDice)
		{
			startingNumberOfDice = numberOfDice;
		}

		public int Run()
		{
			var diceInRoll = CreateDiceInRollList();

			int score = 0;

			do
			{
				score += Roll(diceInRoll);
			} while (diceInRoll.Count > 0);

			return score;
		}

		private int Roll(List<DieRoll> diceInRoll)
		{
			foreach (var dieRoll in diceInRoll)
			{
				dieRoll.Roll();
			}

			var diceWith3 = diceInRoll.Where(d => d.RolledValue == 3);
			if (diceWith3.Count() > 0)
			{
				while (diceWith3.Count() > 0)
				{
					diceInRoll.Remove(diceWith3.First());
				}

				return 0;
			}
			else
			{
				if (diceInRoll.Count > 1)
				{
					diceInRoll.Sort(CompareDieByValue);
				}

				// Removing just the lowest die. If there are more than one with the same value, just the first is removed and its value returned
				var lowestDie = diceInRoll.First();
				var lowestValue = lowestDie.RolledValue;
				diceInRoll.Remove(lowestDie);

				return lowestValue;
			}
		}

		private static int CompareDieByValue(DieRoll x, DieRoll y)
		{
			if (x.RolledValue == y.RolledValue)
			{
				return 0;
			}
			else if (x.RolledValue > y.RolledValue)
			{
				return 1;
			}
			else
			{
				return -1;
			}
		}

		private List<DieRoll> CreateDiceInRollList()
		{
			var result = new List<DieRoll>(startingNumberOfDice);

			for (int i = 1; i <= startingNumberOfDice; i++)
			{
				result.Add(new DieRoll(i));
			}

			return result;
		}
	}
}
