namespace CountVowels.Test;

public class CountVowelsTest
{
    [Fact]
    public void Count_On_EmptyString()
    {
        string line = string.Empty;


        int[] result = CountVowels.Count(line);
        int[] answer = {0, 0, 0, 0, 0};

        Assert.Equal(result, answer);

    }

    [Fact]
    public void Count_On_SingleCharacterString()
    {
        string line = "a";


        int[] result = CountVowels.Count(line);
        int[] answer = {1, 0, 0, 0, 0};

        Assert.Equal(result, answer);

    }

    [Fact]
    public void Count_On_SingleCharacterString_NoVowel()
    {
        string line = "c";


        int[] result = CountVowels.Count(line);
        int[] answer = {0, 0, 0, 0, 0};

        Assert.Equal(result, answer);

    }

    [Fact]
    public void Count_On_RegularString_1()
    {
        string line = "Hello World";


        int[] result = CountVowels.Count(line);
        int[] answer = {0, 1, 0, 2, 0};

        Assert.Equal(result, answer);

    }

    [Fact]
    public void Count_On_RegularString_2()
    {
        string line = "Good evening everyone! How are you?";


        int[] result = CountVowels.Count(line);
        int[] answer = {1, 6, 1, 5, 1};

        Assert.Equal(result, answer);

    }

    [Fact]
    public void Count_On_AllVowels()
    {
        string line = "AAaaEEeeooOOiiIIuuUU";


        int[] result = CountVowels.Count(line);
        int[] answer = {4, 4, 4, 4, 4};

        Assert.Equal(result, answer);

    }
}
