using System;

namespace GameRoulette
{
	class MainClass
	{
		// ----------- Methods -------------
		static void Write(string str)
		{
			Console.Write(str);

		}
		static void Write(char chr)
		{
			Console.Write(chr);

		}
		static void Write(int intr)
		{
			Console.Write(intr);

		}

		static string Conv()
		{
			string temp = Console.ReadLine();
			return temp;

		}

		static void SkipLines(int howMany)
		{
			do
			{
				Console.WriteLine();
				howMany--;

			} while (howMany > 0);
		}

		static int GetRandomNumber(Random rnd)
		{
			int randNumb = rnd.Next(1, 1);
			// Random number between 1 & 36

			return randNumb;
		}

		static int IntWin(int gamble, int randNumb)
		{
			if (gamble == randNumb)
			{
				Console.WriteLine("The roulette is rolling... \nIt stops on the " + randNumb + ".\nYou win, bet multiply by 5 !");
				return 5;

			}

			Console.WriteLine("The roulette is rolling... \nIt stops on the " + randNumb + ".\nYou lost, bet equals to 0 !");
			return 0;
		}

		static int ColorWin(int randNumb, int[] array)
		{
			foreach (int num in array)
			{
				if (num == randNumb)
				{
					Console.WriteLine("The roulette is rolling so fast !\nIt stops right on your color.\nCongrats, you win : bet multiply by 2");
					return 2;

				}
			}

			Console.WriteLine("You lost, it isn't the right color.\nToo bad : bet equals to 0.");
			return 0;
		}

		// ------------ Variables -------------
		static int[] red_nums = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36 };

		static int[] black_nums = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35 };

		static Random rand = new Random();
		static int gamble;

		// --------------- Class ---------------
		public class Sold
		{
			private int sold;

			public Sold()
			{
				sold = 100;

			}

			public void ShowSold()
			{
				Console.WriteLine("Sold : " + sold + "$");

			}

			public void Add(int bet)
			{
				sold += bet;

			}

			public void Sub(ref int bet)
			{
				if ((sold - bet) < 0)
				{
					bet = sold;
					Console.WriteLine("Bet set to " + bet + ".");
				}

				sold -= bet;

			}

			public bool CheckForGameOver()
			{
				if (sold <= 0)
				{
					return true;

				}

				return false;
			}

		}

		public static void Main(string[] args)
		{
			Sold player = new Sold();

			Write("Hello and welcome to MSSA SD7 roulette game.");

			SkipLines(3);

			Write("\nYou start the game with 100$.\nYou can bet on a number or on a color.\nBet on color will multiply your bet by 2 where a number bet will multiply it by 5.\nTo bet, just write a number between 1 & 36 or red or black.\nGood luck and have fun :)\n");

			SkipLines(2);

			while (true)
			{
				try
				{
					SkipLines(1);
					player.ShowSold();

					Write("Bet ? ");
					gamble = Convert.ToInt32(Conv());

				}
				catch (Exception)
				{
					Write("You have to gamble so your bet is 10.\n");
					gamble = 10;

				}

				player.Sub(ref gamble);
				int randomNumber = GetRandomNumber(rand);
				int mult = 0;

				Write("On what ? ");
				string write = Conv().ToLower();

				if (write.Equals("red"))
				{
					mult = ColorWin(randomNumber, red_nums);

				}
				else if (write.Equals("black"))
				{
					mult = ColorWin(randomNumber, black_nums);

				}
				else
				{
					try
					{
						int bet = Convert.ToInt32(write);
						mult = IntWin(bet, randomNumber);

					}
					catch (Exception)
					{
						Write("Wrong input, lost your bet.");

					}
				}

				player.Add(gamble * mult);

				if (player.CheckForGameOver()) goto defeat;
			}

		defeat:
			SkipLines(2);
			Write("You lost, try again an other time :D");
		}
	}
}
