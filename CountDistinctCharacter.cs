using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CountDistinctChararcter
{
    public void countDistinctCharacter(String str)
    {
		int[] arr = new int[26];
		for (int i = 0; i < arr.Length; i++)
		{
			arr[i] = 0;
		}
		int count = 0;
		for (int i = 0; i < arr.Length; i++)
		{
			arr[str[i] - 'a']++;
		}
		for (int i = 0; i < arr.Length; i++)
		{
			if (arr[i] != 0)
			{
				
				Console.WriteLine(Convert.ToChar(arr[i] + 'a'));
				count++;
			}
		}
		Console.WriteLine(count);
	}
}
