namespace RollerCoaster.Test;

public class RCoasterTest
{
    [Fact]
    public void RollerCoaster_Test_1()
    {
        Assert.False(RollerCoaster.CheckHeight(-10, 10));
    }

    [Fact]
    public void RollerCoaster_Test_2()
    {
        Assert.False(RollerCoaster.CheckHeight(90, 89));
    }

    [Fact]
    public void RollerCoaster_Test_3()
    {
        Assert.True(RollerCoaster.CheckHeight(190, 100));
    }

    [Fact]
    public void RollerCoaster_Test_4()
    {
        Assert.True(RollerCoaster.CheckHeight(140, 100));
    }
}
