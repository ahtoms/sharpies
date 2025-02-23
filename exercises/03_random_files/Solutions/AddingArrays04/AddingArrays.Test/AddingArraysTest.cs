namespace AddingArrays.Test;

public class AddingArraysTests
{
    [Fact]
    public void Adding_Empty_Arrays()
    {

        int[] numbersA = {};
        int[] numbersB = {};

        int[] result = AddingArrays.Join(numbersA, numbersB);
        int[] answer = {};
        Assert.Empty(result);
        Assert.Equal(result, answer);

    }

    [Fact]
    public void Adding_Empty_Array_With_OneElementArray()
    {

        int[] numbersA = {1};
        int[] numbersB = {};

        int[] result = AddingArrays.Join(numbersA, numbersB);
        int[] answer = {1};
        Assert.Equal(result, answer);

    }


    [Fact]
    public void Adding_Arrays_WithOneElement()
    {

        int[] numbersA = {1};
        int[] numbersB = {2};

        int[] result = AddingArrays.Join(numbersA, numbersB);
        int[] answer = {1, 2};
        Assert.Equal(2, result.Count());
        Assert.Equal(answer, result);

    }

    [Fact]
    public void Adding_Arrays_WithTwoElements()
    {

        int[] numbersA = {1, 3};
        int[] numbersB = {2, 4};

        int[] result = AddingArrays.Join(numbersA, numbersB);
        int[] answer = {1, 3, 2, 4};
        Assert.Equal(4, result.Count());
        Assert.Equal(answer, result);

    }

    [Fact]
    public void Adding_Arrays_WithThreeElements()
    {

        int[] numbersA = {1, 2, 3};
        int[] numbersB = {4, 5, 6};

        int[] result = AddingArrays.Join(numbersA, numbersB);
        int[] answer = {1, 2, 3, 4, 5, 6};
        Assert.Equal(6, result.Count());
        Assert.Equal(answer, result);

    }

    [Fact]
    public void Adding_Arrays_OfDifferentSize_1()
    {

        int[] numbersA = {1};
        int[] numbersB = {4, 5, 6};

        int[] result = AddingArrays.Join(numbersA, numbersB);
        int[] answer = {1, 4, 5, 6};
        Assert.Equal(4, result.Count());
        Assert.Equal(answer, result);

    }

    [Fact]
    public void Adding_Arrays_OfDifferentSize_2()
    {

        int[] numbersA = {1, 2, 3, 4, 5, 6, 7, 8};
        int[] numbersB = {9, 10, 11};

        int[] result = AddingArrays.Join(numbersA, numbersB);
        int[] answer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};
        Assert.Equal(11, result.Count());
        Assert.Equal(answer, result);

    }
}
