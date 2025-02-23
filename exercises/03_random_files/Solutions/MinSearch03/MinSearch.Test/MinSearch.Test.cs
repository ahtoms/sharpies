namespace MinSearch.Test;



public class MinSearchTest
{
    [Fact]
    public void FindMin_On_EmptyArray()
    {
        int[] emptyArray = new int[0];
        int? result = MinSearch.Find(emptyArray);
        Assert.Null(result);
    }

    [Fact]
    public void FindMin_On_SingleArray()
    {
        int[] singleArray = { 1 };
        int? result = MinSearch.Find(singleArray);
        Assert.NotNull(result);
        Assert.Equal(result, 1);
    }

    [Fact]
    public void FindMin_On_ArrayOfTwo()
    {
        int[] array = { 1, 2 };
        int? result = MinSearch.Find(array);
        Assert.NotNull(result);
        Assert.Equal(result, 1);
    }

    [Fact]
    public void FindMin_On_ArrayOfTwo_ReverseOrder()
    {
        int[] array = { 2, 1 };
        int? result = MinSearch.Find(array);
        Assert.NotNull(result);
        Assert.Equal(result, 1);
    }

    [Fact]
    public void FindMin_On_LargerArray()
    {
        int[] array = { 2, 1, 3, 5, 0 };
        int? result = MinSearch.Find(array);
        Assert.NotNull(result);
        Assert.Equal(result, 0);
    }

    [Fact]
    public void FindMin_On_LargerArray_WithNegatives()
    {
        int[] array = { 2, -1, 3, -5, 0 };
        int? result = MinSearch.Find(array);
        Assert.NotNull(result);
        Assert.Equal(result, -5);
    }

}

