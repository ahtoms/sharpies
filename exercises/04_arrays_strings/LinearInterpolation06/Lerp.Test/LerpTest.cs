namespace Lerp.Test;

public class UnitTest1
{
    [Fact]
    public void LinearInterpolation_1DTest_1()
    {
        Assert.Equal(0, Lerp.LinearInterpolation(0, 1, 0), 0.1);
    }

    [Fact]
    public void LinearInterpolation_1DTest_2()
    {
        Assert.Equal(1, Lerp.LinearInterpolation(1, 2, 0), 0.1);
    }

    [Fact]
    public void LinearInterpolation_1DTest_3()
    {
        Assert.Equal(0.5f, Lerp.LinearInterpolation(0, 1, 0.5f), 0.1);
    }

    [Fact]
    public void LinearInterpolation_1DTest_4()
    {
        Assert.Equal(6f, Lerp.LinearInterpolation(5, 7, 0.5f), 0.1);
    }

    [Fact]
    public void LinearInterpolation_1DTest_5()
    {
        Assert.Equal(11.5f, Lerp.LinearInterpolation(9, 19, 0.25f), 0.01);
    }

    [Fact]
    public void LinearInterpolation_1DTest_6()
    {
        Assert.Equal(16.5f, Lerp.LinearInterpolation(9, 19, 0.75f), 0.01);
    }

    //TODO: Do 2D linear interpolation

}
