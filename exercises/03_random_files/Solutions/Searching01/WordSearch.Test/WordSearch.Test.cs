namespace WordSearch.Test;

public class WordSearchTest
{
    [Fact]
    public void WordSearch_FindIndex_Single_Found()
    {
        string[] words = {
            "Line",
        };

        string word = "Line";

        int? idx = WordSearcher.FindIndex(words, word);

        Assert.NotNull(idx);
        Assert.Equal(0, idx);
    }

    [Fact]
    public void WordSearch_FindIndex_Single_NotFound()
    {
        string[] words = {
            "Line",
        };

        string word = "Cat";

        int? idx = WordSearcher.FindIndex(words, word);

        Assert.Null(idx);
    }

    [Fact]
    public void WordSearch_FindIndex_FiveWords_WordFound_First()
    {
        string[] words = {
            "Line",
            "Cat",
            "Popcorn",
            "Movie",
            "Television"
        };

        string word = "Line";

        int? idx = WordSearcher.FindIndex(words, word);

        Assert.NotNull(idx);
        Assert.Equal(0, idx);
    }

    [Fact]
    public void WordSearch_FindIndex_FiveWords_WordFound_Third()
    {
        string[] words = {
            "Line",
            "Cat",
            "Popcorn",
            "Movie",
            "Television"
        };

        string word = "Popcorn";

        int? idx = WordSearcher.FindIndex(words, word);

        Assert.NotNull(idx);
        Assert.Equal(2, idx);
    }

    [Fact]
    public void WordSearch_FindIndex_FiveWords_WordFound_Last()
    {
        string[] words = {
            "Line",
            "Cat",
            "Popcorn",
            "Movie",
            "Television"
        };

        string word = "Television";

        int? idx = WordSearcher.FindIndex(words, word);

        Assert.NotNull(idx);
        Assert.Equal(4, idx);
    }

    [Fact]
    public void WordSearch_FindIndex_Array_NotFound()
    {
        string[] words = {
            "Line",
            "Cat",
            "Popcorn",
            "Movie",
            "Television"
        };

        string word = "Lost";

        int? idx = WordSearcher.FindIndex(words, word);

        Assert.Null(idx);
    }


}
