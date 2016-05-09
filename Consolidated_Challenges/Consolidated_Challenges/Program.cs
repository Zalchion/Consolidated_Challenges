using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Consolidated_Challenges
{
	class Program
	{
		static void Main(string[] args)
		{	
			while(true)
			{
				Console.WriteLine("Write the number of the challenge you wish to view IE ('001' or '077').\n '!help' for commands or '!quit' to quit");
				string input = Console.ReadLine();
				input = input.ToLower().Trim();

				Console.WriteLine(input);

				if(input == "!exit" || input == "!quit" || input == "!q")
					break;
				if(input.Length > 0 && input[0] == '!')
				{
					switch(input)
					{
						case "!list":
							//TODO: loops through all challenges and show them.
							break;
						case "!clear":
							Console.Clear();
							Console.WriteLine("Write the number of the challenge you wish to view.\n '!help' for commands");
							break;
						default:
							Console.WriteLine("Commands: !list, !clear, !quit, !exit");
							break;
					}
				}
				else
				{
					switch(input)
					{
						case "001":
							var c001 = new Consolidated_Challenges.Challenge001();
							c001.Challenge_001();
							break;
						case "002":
							var c002= new Consolidated_Challenges.Challenge002();
							c002.Challenge_002();
							break;
						default:
							Console.WriteLine(input + " does not exist.");
							break;
					}

					
					
				}

			}

			Console.WriteLine("Press any key to exit");
			Console.ReadLine();
		}

	}
}



/*
 			Console.WriteLine("Wish to open the challenge?");
			string input = Console.ReadLine();
			if(input == "yes" || input == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/pih8x/easy_challenge_1/");
 */
