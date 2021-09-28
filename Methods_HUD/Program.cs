using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_HUD
{
	class RandomGenerator
	{
		// Declarations:
		static int score;
		static string name;
		static int xp;
		static int gold;
		static int health;
		static int multiplier;
		static int finalScore;
		//static RandomNumber = new Random();

		//Method that shows the hud
		static void ShowHUD()
		{
			Console.WriteLine("======================================");
			Console.WriteLine("score = " + finalScore);
			Console.WriteLine("name = " + name);
			Console.WriteLine("xp = " + xp);
			Console.WriteLine("Multiplier: " + multiplier);
			Console.WriteLine("Gold = " + gold);
			Console.WriteLine("Health = " + health);
			Console.WriteLine("======================================");
			Console.WriteLine("");
		}

		static void TakeDamage(int damage)
		{					
			health = health - damage; ;
	
		}

/*		static void Damage()
		{

			RandomNumber = UnityEngine.Eandom.Range(1, 100);


		}*/

		static void Main(string[] args)
		{

			// Methods(AKA Procedures, Functions,...)

			//ShowHUD();


			// Initialize
			score = 0;
			name = "Madore902";
			xp = 0;
			gold = 0;
			health = 100;
			multiplier = 2;

			ShowHUD();

			// Random Int Generator

			System.Random random = new System.Random();



			//Simulated gameplay
			Console.WriteLine("");
			Console.WriteLine("A demon dog came out of it's den as you pass by and attacks!!!!!");
			Console.WriteLine("You shoot it down after taking some damage");
			Console.WriteLine("");
			score = score + 100;
			xp = xp + 50;
			gold = gold + 150;
			finalScore = score * multiplier;

			TakeDamage(random.Next(1, 25));
			ShowHUD();

			//Simulated Gameplay

			Console.WriteLine("");
			Console.WriteLine("A tiny cute creature appears but it's not so cute anymore as it jump at you and claws at your face!!!!!!!!!!!!!!");
			Console.WriteLine("You manage to rip it off and kill it");
			Console.WriteLine("");

			score = score + 100;
			xp = xp + 50;
			gold = gold + 150;
			finalScore = score * multiplier;

			TakeDamage(random.Next(1, 25));
			ShowHUD();

			Console.ReadKey(true);
		}
	}
}
