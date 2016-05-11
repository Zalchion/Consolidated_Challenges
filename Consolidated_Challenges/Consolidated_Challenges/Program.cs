using System;
using System.Reflection;
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
			Console.WriteLine("I started doing the challenges to learn programming by myself.\nMost early challenges is very badly done, some have been revisited.");
			while(true)
			{
				Console.WriteLine("Write the number of the challenge you wish to view IE ('001' or '077').\n 'help' for commands or 'quit' to quit");
				string input = Console.ReadLine();
				input = input.ToLower().Trim();

				if(input == "exit" || input == "quit" || input == "q" || input == "n" || input == "no")
					break;
				if(input.Length > 0 && !char.IsDigit(input[0]))
				{
					switch(input)
					{
						case "list":
							//Loops through all available challenges and show them.
							Console.WriteLine();
							string nameSpace = "Consolidated_Challenges";							
							var q = from t in Assembly.GetExecutingAssembly().GetTypes()
									where t.IsClass && t.Namespace == nameSpace && t.Name.Substring(0, 3) == "Cha"
									select t.Name;
							q.OrderBy(s => s).ToList().ForEach(t => Console.Write(t.Substring(t.Length-3, 3) + "\t"));
							Console.WriteLine();
							break;
						case "clear":
							Console.Clear();
							break;
						default:
							Console.WriteLine("\nThe command '" + input + "' does not exist.\n");
							break;
					}
				}
				else if(input.Length > 0 && char.IsDigit(input[0]))
				{
					string myClass = "Challenge" + input;
					string myMethod = "Challenge_" + input;
					StartChallenge(myClass, myMethod, input);
				}
				else
					Console.WriteLine("Commands: list, clear, quit, exit or a three digit number\n");
			}
		}

		public static void StartChallenge(string myClass, string myMethod, string challenge)
		{			
			try
			{
				//Gets the challenge class and starts it unless an error is thrown
				Type type = Type.GetType("Consolidated_Challenges." + myClass);
				MethodInfo methodInfo = type.GetMethod(myMethod);
				Object obj = Activator.CreateInstance(type);
				Console.Clear();
				Console.WriteLine("Starting challenge " + challenge);
				methodInfo.Invoke(obj, null);
			}
			catch(Exception)
			{
				//The challenge number did not exist
				Console.WriteLine(myClass + " does not exist. type 'list' to see the list of all challenges\n");
			}
		}
	}
}

/*
 			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("");
 */
