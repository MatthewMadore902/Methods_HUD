using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_HUD
{
	class Program
	{
		// Declarations:
		static int score;
		static string name;
		static int xp;
		static int gold;
		static int health;
		//Method that shows the hud
		static void ShowHUD()
		{
			Console.WriteLine("======================================");
			Console.WriteLine("score = " + score);
			Console.WriteLine("name = " + name);
			Console.WriteLine("xp = " + xp);
			Console.WriteLine("Gold = " + gold);
			Console.WriteLine("Health = " + health);
			Console.WriteLine("======================================");
			Console.WriteLine("");
		}

		static void TakeDamage(int damage)
		{
			
			health = health - damage;
		
		}

		static void Main(string[] args)
		{

			// Methods(AKA Procedures, Functions,...)

			ShowHUD();


			// Initialize
			score = 0;
			name = "Madore902";
			xp = 0;
			gold = 0;
			health = 100;




			//Simulated gameplay
			score = score + 100;
			xp = xp + 50;
			gold = gold + 150;

			TakeDamage(25);
			ShowHUD();

			score = score + 100;
			xp = xp + 50;
			gold = gold + 150;

			TakeDamage(12);
			ShowHUD();

			Console.ReadKey(true);
		}
	}
}
