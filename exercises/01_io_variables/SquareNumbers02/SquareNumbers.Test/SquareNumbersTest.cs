namespace SquareNumbers.Test;

public class SquareNumbersTest
{
    [Fact]
    public void SquareNumbers_Test_1()
    {
        TermController ctlr = new TermController()
        .RecordStdOut()
        .FindAndInvokeMain("Program, SquareNumbers", new string[] { "6" });

        ctlr.FlushStdOut();

        string output = ctlr.GetOutputString();

        Assert.Equal("36\n", output);

        ctlr.ResetAll();
    }


    [Fact]
    public void SquareNumbers_Test_2()
    {
        TermController ctlr = new TermController()
        .RecordStdOut()
        .FindAndInvokeMain("Program, SquareNumbers", new string[] { "10" });

        ctlr.FlushStdOut();

        string output = ctlr.GetOutputString();

        Assert.Equal("100\n", output);

        ctlr.ResetAll();
    }

    [Fact]
    public void SquareNumbers_Test_3()
    {
        TermController ctlr = new TermController()
        .RecordStdOut()
        .FindAndInvokeMain("Program, SquareNumbers", new string[] { "2" });

        ctlr.FlushStdOut();

        string output = ctlr.GetOutputString();

        Assert.Equal("4\n", output);

        ctlr.ResetAll();
    }
}
