using System;

public class Anagram
{
	public Boolean isAnagram(string str1, string str2)
	{
		if ((str1 == null || str2 == null) || (str1.Length != str2.Length))
		{
			return false;
		}

		char[] chars = str1.ToCharArray();
		char[] chars2 = str2.ToCharArray();

		Array.Sort(chars);
		Array.Sort(chars2);

		for (int i = 0; i < chars.Length; i++)
		{
			if (chars[i] != chars2[i])
				return false;
		}

		return true;
	}

	
}

