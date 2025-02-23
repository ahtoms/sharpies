namespace DieRoll.Test;




public class DieRollTestRunner
{
    [Fact]
    public void DieRoll_Produces_Something()
    {
        TermController ctlr = new TermController()
        .RecordStdOut()
        .FindAndInvokeMain("Program, DieRoll", new string[] {});

        ctlr.FlushStdOut();

        string output = ctlr.GetOutputString();
        int n = int.Parse(output);


        Assert.True(n >= 1 && n <= 6);

        ctlr.ResetAll();


    }

    [Fact]
    public void DieRoll_Produces_Roll_ALot()
    {
        int[] counts = { 0, 0, 0, 0, 0, 0 };
        int minThres = 2;
        int maxThres = 400;

        for(int i = 0; i < 2000; i++) {
            TermController ctlr = new TermController()
            .RecordStdOut()
            .FindAndInvokeMain("Program, DieRoll", new string[] {});

            ctlr.FlushStdOut();

            string output = ctlr.GetOutputString();
            int n = int.Parse(output);


            Assert.True(n >= 1 && n <= 6);
            counts[(n-1)] += 1;

            ctlr.ResetAll();
        }

        for(int i = 0; i < 6; i++) {
            int accum = 0;
            for(int j = 0; j < 6; j++) {
                accum += counts[i] - counts[j];

                if(Math.Abs(counts[i] - counts[j]) >= maxThres) {
                    Assert.Fail("Exceeded threshold: " + string.Join(", ", counts));
                }

            }
            if(Math.Abs(accum) <= minThres) {
                Assert.Fail("Lack of randomness, "+ accum + ": " + string.Join(", ", counts)
                    + " - This can be a false-positive"
                );

            }
        }



    }
}
