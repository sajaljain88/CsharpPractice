using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ReverseString
{
	public void reverseString(string str1)
	{

		string rev = "";
		for (int i = str1.Length-1; i >=0; i--)
		{
			rev += str1[i];
		}
		Console.WriteLine(rev);
	}
	
   
}
