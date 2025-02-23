namespace RowMajor.Test;

public class RowMajorTest
{
    [Fact]
    public void RowMajor_Construct()
    {
        int[] numbers = {
            0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
            10, 11, 12, 13, 14, 15, 16, 17, 18, 19,
            20, 21, 22, 23, 24, 25, 26, 27, 28, 29
        };

        RowMajorArray rma = new RowMajorArray(numbers, 10, 3);

        Assert.NotNull(rma);
    }

    [Fact]
    public void RowMajor_Access_First()
    {
        int[] numbers = {
            0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
            10, 11, 12, 13, 14, 15, 16, 17, 18, 19,
            20, 21, 22, 23, 24, 25, 26, 27, 28, 29
        };

        RowMajorArray rma = new RowMajorArray(numbers, 10, 3);

        Assert.NotNull(rma);

        Assert.Equal(0, rma.Get(0, 0));
    }

    [Fact]
    public void RowMajor_Access_NextRow()
    {
        int[] numbers = {
            0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
            10, 11, 12, 13, 14, 15, 16, 17, 18, 19,
            20, 21, 22, 23, 24, 25, 26, 27, 28, 29
        };

        RowMajorArray rma = new RowMajorArray(numbers, 10, 3);

        Assert.NotNull(rma);

        Assert.Equal(10, rma.Get(0, 1));
    }

    [Fact]
    public void RowMajor_Access_LastRow()
    {
        int[] numbers = {
            0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
            10, 11, 12, 13, 14, 15, 16, 17, 18, 19,
            20, 21, 22, 23, 24, 25, 26, 27, 28, 29
        };

        RowMajorArray rma = new RowMajorArray(numbers, 10, 3);

        Assert.NotNull(rma);

        Assert.Equal(20, rma.Get(0, 2));
    }

    [Fact]
    public void RowMajor_Access_LastEntry_OnFirst()
    {
        int[] numbers = {
            0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
            10, 11, 12, 13, 14, 15, 16, 17, 18, 19,
            20, 21, 22, 23, 24, 25, 26, 27, 28, 29
        };

        RowMajorArray rma = new RowMajorArray(numbers, 10, 3);

        Assert.NotNull(rma);

        Assert.Equal(9, rma.Get(9, 0));
    }

    [Fact]
    public void RowMajor_Access_LastEntry_OnSecond()
    {
        int[] numbers = {
            0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
            10, 11, 12, 13, 14, 15, 16, 17, 18, 19,
            20, 21, 22, 23, 24, 25, 26, 27, 28, 29
        };

        RowMajorArray rma = new RowMajorArray(numbers, 10, 3);

        Assert.NotNull(rma);

        Assert.Equal(19, rma.Get(9, 1));
    }

    [Fact]
    public void RowMajor_Access_LastEntry_OnLast()
    {
        int[] numbers = {
            0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
            10, 11, 12, 13, 14, 15, 16, 17, 18, 19,
            20, 21, 22, 23, 24, 25, 26, 27, 28, 29
        };

        RowMajorArray rma = new RowMajorArray(numbers, 10, 3);

        Assert.NotNull(rma);

        Assert.Equal(29, rma.Get(9, 2));
    }


}
