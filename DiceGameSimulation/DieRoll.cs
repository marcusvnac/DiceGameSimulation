using System;

namespace DiceGameSimulation
{
	public class DieRoll
	{
		public int Id { get; private set; }
		public int RolledValue { get; private set; }

		public DieRoll(int id)
		{
			Id = id;
		}

		public void Roll()
		{
			RolledValue = new Random().Next(1, 6);
		}
	}
}
