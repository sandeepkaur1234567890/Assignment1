using System;
using System.Collections.Generic;

namespace Assignment1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the number of cards to pick: ");
			string line = Console.ReadLine();
			if (int.TryParse(line, out int numCards))
			{
				foreach (var card in CardPicker.PickSomeCards(numCards))
				{
					Console.WriteLine(card);
				}
			}
			else
			{
				Console.WriteLine("Please enter a valid number.");
			}
		}
	}

	public static class SubsequenceFinder
	{
		/// <summary>
		/// Determines whether a list of integers is a subsequence of another list of integers
		/// </summary>
		/// <param name="seq">The main sequence of integers.</param>
		/// <param name="subseq">The potential subsequence.</param>
		/// <returns>True if subseq is a subsequence of seq and false otherise.</returns>
		public static bool IsValidSubsequeuce(List<int> seq, List<int> subseq)
		{
			throw new NotImplementedException();
		}
	}

	class CardPicker
	{
		static Random random = new Random(1);
		/// <summary>
		/// Picks a random (with replacement) number of cards.
		/// </summary>
		/// <param name="numCards">The number of cards to choose at random.</param>
		/// <returns>An array of strings where each string represents a card.</returns>
		public static string[] PickSomeCards(int numCards)
		{
			RandomValue();
			RandomSuit();
		}
		/// <summary>
		/// Chooses a random value for a card (Ace, 2, 3, ... , Queen, King)
		/// </summary>
		/// <returns>A string that represents the value of a card</returns>
		private static string RandomValue()
		{
			string[] faces = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king" };
		}
		/// <summary>
		/// Chooses a random suit for a card (Clubs, Diamonds, Hearts, Spades)
		/// </summary>
		/// <returns>A string that represents the suit of a card.</returns>
		private static string RandomSuit()
		{
			string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades" };
		}
	}
}
