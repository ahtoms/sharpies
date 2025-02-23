namespace CountVowels;

public class CountVowels
{

    public static int[] Count(string line) {
        int[] counts = { 0, 0, 0, 0, 0 };

        for(int i = 0; i < line.Count(); i++) {
            char c = line[i];
            if(c == 'a' || c == 'A') {
                counts[0]++;
            } else if(c == 'e' || c == 'E') {
                counts[1]++;
            } else if(c == 'i' || c == 'I') {
                counts[2]++;
            } else if(c == 'o' || c == 'O') {
                counts[3]++;
            } else if(c == 'u' || c == 'U') {
                counts[4]++;
            }
        }

        return counts;
    }

}
