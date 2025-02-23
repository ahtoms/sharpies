namespace ArraySelect.Test;

public class ArraySelectTest
{
    [Fact]
    public void ArraySelect_WithinBound1()
    {
        int[] numbers = {10, 20, 30, 40, 50 };

        int? v = ArraySelect.Select(numbers, 0);

        Assert.NotNull(v);
        Assert.Equal(10, v);

    }

    [Fact]
    public void ArraySelect_WithinBound2()
    {
        int[] numbers = {10, 20, 30, 40, 50 };

        int? v = ArraySelect.Select(numbers, 4);

        Assert.NotNull(v);
        Assert.Equal(50, v);

    }

    [Fact]
    public void ArraySelect_WithinBound3()
    {
        int[] numbers = {10, 20, 30, 40, 50 };

        int? v = ArraySelect.Select(numbers, 2);

        Assert.NotNull(v);
        Assert.Equal(30, v);

    }

    [Fact]
    public void ArraySelect_ZeroArray()
    {
        int[] numbers = {};

        int? v = ArraySelect.Select(numbers, 2);

        Assert.Null(v);

    }

    [Fact]
    public void ArraySelect_OutOfBounds1()
    {
        int[] numbers = {10, 20, 30, 40, 50 };

        int? v = ArraySelect.Select(numbers, 5);

        Assert.NotNull(v);
        Assert.Equal(10, v);

    }

    [Fact]
    public void ArraySelect_OutOfBounds2()
    {
        int[] numbers = {10, 20, 30, 40, 50 };

        int? v = ArraySelect.Select(numbers, 7);

        Assert.NotNull(v);
        Assert.Equal(30, v);

    }

    [Fact]
    public void ArraySelect_OutOfBounds3()
    {
        int[] numbers = {10, 20, 30, 40, 50 };

        int? v = ArraySelect.Select(numbers, 11);

        Assert.NotNull(v);
        Assert.Equal(20, v);

    }

    [Fact]
    public void ArraySelect_OutOfBoundsNegative1()
    {
        int[] numbers = {10, 20, 30, 40, 50 };

        int? v = ArraySelect.Select(numbers, -1);

        Assert.NotNull(v);
        Assert.Equal(50, v);

    }

    [Fact]
    public void ArraySelect_OutOfBoundsNegative2()
    {
        int[] numbers = {10, 20, 30, 40, 50 };

        int? v = ArraySelect.Select(numbers, -4);

        Assert.NotNull(v);
        Assert.Equal(20, v);

    }

    [Fact]
    public void ArraySelect_OutOfBoundsNegative3()
    {
        int[] numbers = {10, 20, 30, 40, 50 };

        int? v = ArraySelect.Select(numbers, -6);

        Assert.NotNull(v);
        Assert.Equal(50, v);

    }
}
