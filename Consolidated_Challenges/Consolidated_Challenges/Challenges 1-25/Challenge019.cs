using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge019
	{
		public void Challenge_019()
		{
			int count = 0;
			var file = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\challenge019.txt");

			foreach(var row in file)
			{
				foreach(var letter in row)
				{
					if(letter.ToString().All(c => Char.IsLetterOrDigit(c)))
						count++;
				}
			}
			Console.WriteLine(count);

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/qlwrc/372012_challenge_19_easy/");
		}
	}
}
