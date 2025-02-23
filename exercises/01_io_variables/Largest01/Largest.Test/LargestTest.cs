namespace Largest.Test;

public class LargestTest
{


    [Fact]
    public void Largest_Test_1()
    {

        TermController ctlr = new TermController()
            .RecordStdOut()
            .SetStringInput("15\n20\n")
            .FindAndInvokeMain("Program, Largest", new string[] {});

        ctlr.FlushStdOut();

        string output = ctlr.GetOutputString();
        string[] nlineOutput = output.Split("\n");
        Console.WriteLine(output + ": !!");

        Assert.Equal("Enter value for A: ", nlineOutput[0]);
        Assert.Equal("Enter value for B: ", nlineOutput[1]);
        Assert.Equal("", nlineOutput[2]);
        Assert.Equal("20 is the largest", nlineOutput[3]);

        ctlr.ResetAll();
    }

    [Fact]
    public void Largest_Test_2()
    {

        TermController ctlr = new TermController()
        .RecordStdOut()
        .SetStringInput("40\n9\n")
        .FindAndInvokeMain("Program, Largest", new string[] {});

        ctlr.FlushStdOut();

        string output = ctlr.GetOutputString();
        string[] nlineOutput = output.Split("\n");
        Console.WriteLine(output + ": !!");

        Assert.Equal("Enter value for A: ", nlineOutput[0]);
        Assert.Equal("Enter value for B: ", nlineOutput[1]);
        Assert.Equal("", nlineOutput[2]);
        Assert.Equal("40 is the largest", nlineOutput[3]);

        ctlr.ResetAll();
    }

    [Fact]
    public void Largest_Test_3()
    {

        TermController ctlr = new TermController()
        .RecordStdOut()
        .SetStringInput("50\n50\n")
        .FindAndInvokeMain("Program, Largest", new string[] {});

        ctlr.FlushStdOut();

        string output = ctlr.GetOutputString();
        string[] nlineOutput = output.Split("\n");
        Console.WriteLine(output + ": !!");

        Assert.Equal("Enter value for A: ", nlineOutput[0]);
        Assert.Equal("Enter value for B: ", nlineOutput[1]);
        Assert.Equal("", nlineOutput[2]);
        Assert.Equal("50 is the largest but the other value was the same", nlineOutput[3]);

        ctlr.ResetAll();
    }
}
