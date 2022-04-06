using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Program
	{
		public static void Main(String[] args)
		{
			Anagram anagram = new Anagram();
			ReverseString reverseString = new ReverseString();
			SumOfNNumbers sumOfNNumbers = new SumOfNNumbers();
			PrimeNumber primeNumber = new PrimeNumber();
			FactorialNumber factorialNumber = new FactorialNumber();
			TargetSum targetSum = new TargetSum();
			CountDistinctChararcter countDistinctChararcter = new CountDistinctChararcter();
			int[] arr = new int[5];
			int x;


			Console.WriteLine("Press 1 Check for an Anagram");
			Console.WriteLine("Press 2 Reverse the String");
			Console.WriteLine("Press 3 to find the sum of N numbers");
			Console.WriteLine("Press 4 to find the factorial of a number");
			Console.WriteLine("Press 5 to Check the Number is Prime or Not");
			Console.WriteLine("Press 6 to Check the target is equals to the sum of array element or not");
			Console.WriteLine("Press 7 to count the distinct Charater");

			int input = Convert.ToInt32(Console.ReadLine());


			switch (input)
			{

				case 1:
					Console.WriteLine("Enter First String");
					string str2 = Console.ReadLine();
					Console.WriteLine("Enter Another String to be check");
					string str3 = Console.ReadLine();
					Console.WriteLine(anagram.isAnagram(str2, str3));
					break;
				case 2:
					Console.WriteLine("Enter String");
					string str4 = Console.ReadLine();
					reverseString.reverseString(str4);
					break;
				case 3:
					Console.WriteLine("Enter the Number");
					int n = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine(sumOfNNumbers.sumOfNNumbers(n));
					break;
				case 4:
					Console.WriteLine("Enter the Number");
					int n1 = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine(factorialNumber.factorialNumber(n1));
					break;
				case 5:
					Console.WriteLine("Enter the Number");
					int n2 = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine(primeNumber.primeNumber(n2));
					break;
				case 6:
					Console.WriteLine("Enter the Number");
					arr = new int[5];
					for (int i = 0; i < arr.Length; i++)
					{
						arr[i] = Convert.ToInt32(Console.ReadLine());
					}
					int target = Convert.ToInt32(Console.ReadLine());

					Console.WriteLine(targetSum.targetSumOfProblem(arr, target));
					Console.WriteLine("Enter the Target");
					x = Convert.ToInt32(Console.ReadLine());

					break;
				case 7:
					Console.WriteLine("Enter the String");
					string str6 = Console.ReadLine();
					countDistinctChararcter.countDistinctCharacter(str6);
					break;
				default:
					Console.WriteLine("Select from above Choices");
					break;
			}

		}
	}
}
