
namespace Palindrome;

public class Palindrome
{
	
	/**
	 *
	 */
	public static bool IsPalindrome(string line)
	{

		for(int i = 0; i < (line.Count()/2); i++)
		{
			char s = line[i];
			char e = line[line.Count() - i - 1];

			if(s != e) {
				//There isn't a match
				return false;
			}

		}

		return true;
	}

}
