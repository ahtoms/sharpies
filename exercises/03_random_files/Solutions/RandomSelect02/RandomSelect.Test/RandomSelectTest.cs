namespace RandomSelect.Test;

public class RandomSelectTest
{
    [Fact]
    public void RandomSelect_Test_Empty()
    {
        int[] numbers = {};
        int? v = RandomSelect.Select(numbers);

        Assert.Null(v);

    }

    [Fact]
    public void RandomSelect_Test_One()
    {
        int[] numbers = {1};
        int? v = RandomSelect.Select(numbers);

        Assert.NotNull(v);
        Assert.Equal(1, v);

    }

    [Fact]
    public void RandomSelect_Test_Two()
    {
        int[] numbers = {1, 2};
        int? v = RandomSelect.Select(numbers);

        Assert.NotNull(v);
        Assert.True(Array.IndexOf(numbers, v) >= 0);

    }

    [Fact]
    public void RandomSelect_Test_Three()
    {
        int[] numbers = {1, 10, 44};
        int? v = RandomSelect.Select(numbers);

        Assert.NotNull(v);
        Assert.True(Array.IndexOf(numbers, v) >= 0);

    }
}
