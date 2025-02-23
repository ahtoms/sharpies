namespace VolumeOfSphere.Test;

public class VOSTestRunner
{
    [Fact]
    public void VOS_Test_1()
    {
        TermController ctlr = new TermController()
        .RecordStdOut()
        .SetStringInput("2")
        .FindAndInvokeMain("Program, VolumeOfSphere", new string[] { });

        ctlr.FlushStdOut();

        string output = ctlr.GetOutputString();
        string[] spl = output.Split("\n");
        Assert.Equal("What is the radius of the sphere: ", spl[0]);
        Assert.Equal("Volume is: 33.51032", spl[1]);

        ctlr.ResetAll();
    }

    [Fact]
    public void VOS_Test_2()
    {
        TermController ctlr = new TermController()
        .RecordStdOut()
        .SetStringInput("3")
        .FindAndInvokeMain("Program, VolumeOfSphere", new string[] { });

        ctlr.FlushStdOut();

        string output = ctlr.GetOutputString();
        string[] spl = output.Split("\n");
        Assert.Equal("What is the radius of the sphere: ", spl[0]);
        Assert.Equal("Volume is: 113.09734", spl[1]);

        ctlr.ResetAll();
    }
}
