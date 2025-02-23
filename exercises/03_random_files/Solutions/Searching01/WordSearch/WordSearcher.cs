namespace WordSearch;

public class WordSearcher
{

    public static string? Find(string[] words, string word) {
        int? index = FindIndex(words, word);
        if(index != null) {
            return words[(int) index];
        } else {
            return null;
        }

    }

    public static int? FindIndex(string[] words, string word) {
        int? match = null;

        for(int i = 0; i < words.Count(); i++) {
            if(words[i].Equals(word)) {
                match = i;
                break;
            }
        }

        return match;

    }

}
