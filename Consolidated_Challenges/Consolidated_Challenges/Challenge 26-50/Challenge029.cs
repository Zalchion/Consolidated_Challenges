using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidated_Challenges
{
	public class Challenge029
	{
		public static string Description()
		{
			return "String manipulation: Palindrome";
		}

		public void Challenge_029()
		{
			Palindrome("Hannah");
			Palindrome("1234321");
			Palindrome("123321");
			Palindrome("12345");
			Palindrome("han nah");
			Palindrome("Dammit I’m mad.");

			Console.WriteLine("Wish to open the challenge?");
			string dailyprogrammer = Console.ReadLine();
			if(dailyprogrammer == "yes" || dailyprogrammer == "y")
				System.Diagnostics.Process.Start("https://www.reddit.com/r/dailyprogrammer/comments/r8a70/3222012_challenge_29_easy/");
		}

		public static void Palindrome(string palindrome)
		{
			bool isPalindrome = true;
			string tempPalindrome = palindrome.ToLower();
			tempPalindrome = tempPalindrome.Replace(" ", "");
			tempPalindrome = tempPalindrome.Replace(".", "");
			tempPalindrome = tempPalindrome.Replace("’", "");
			tempPalindrome = tempPalindrome.Replace("´", "");
			tempPalindrome = tempPalindrome.Replace("'", "");
			tempPalindrome = tempPalindrome.Replace("_", "");
			tempPalindrome = tempPalindrome.Replace("-", "");
			tempPalindrome = tempPalindrome.Replace(",", "");
			tempPalindrome = tempPalindrome.Replace("?", "");
			tempPalindrome = tempPalindrome.Replace("!", "");
			int j = tempPalindrome.Length - 1;
			for(int i = 0; i < tempPalindrome.Length; i++)
			{
				if(tempPalindrome[i] == tempPalindrome[j])
				{
					isPalindrome = true;
					j--;
					break;
				}
				else
				{
					isPalindrome = false;
					j--;
					break;
				}
			}

			if(isPalindrome)
			{
				Console.WriteLine("Changed string: " + tempPalindrome);
				Console.WriteLine("Original string: " + palindrome + " IS a palindrome. \n");
			}
			else
			{
				Console.WriteLine("Changed string: " + tempPalindrome);
				Console.WriteLine("Original string: " + palindrome + " is NOT a palindrome. \n");
			}
		}
	}
}
