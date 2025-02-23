namespace FahToCel.Test;

public class FahToCelTestRunner
{
    [Fact]
    public void FahToCel_Test_1()
    {

        TermController ctlr = new TermController()
        .RecordStdOut()
        .FindAndInvokeMain("Program, FahToCel", new string[] { "32" });

        ctlr.FlushStdOut();

        string output = ctlr.GetOutputString();
        Assert.Equal("0\n", output);


        ctlr.ResetAll();

    }

    [Fact]
    public void FahToCel_Test_2()
    {

        TermController ctlr = new TermController()
        .RecordStdOut()
        .FindAndInvokeMain("Program, FahToCel", new string[] { "104" });

        ctlr.FlushStdOut();

        string output = ctlr.GetOutputString();
        Assert.Equal("40\n", output);


        ctlr.ResetAll();

    }

    [Fact]
    public void FahToCel_Test_3()
    {

        TermController ctlr = new TermController()
        .RecordStdOut()
        .FindAndInvokeMain("Program, FahToCel", new string[] { "68" });

        ctlr.FlushStdOut();

        string output = ctlr.GetOutputString();
        Assert.Equal("20\n", output);


        ctlr.ResetAll();

    }

    [Fact]
    public void FahToCel_Test_4()
    {

        TermController ctlr = new TermController()
        .RecordStdOut()
        .FindAndInvokeMain("Program, FahToCel", new string[] { "14" });

        ctlr.FlushStdOut();

        string output = ctlr.GetOutputString();
        Assert.Equal("-10\n", output);


        ctlr.ResetAll();

    }
}
