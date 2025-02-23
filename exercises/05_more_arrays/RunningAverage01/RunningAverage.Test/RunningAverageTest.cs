namespace RunningAverage.Test;

public class RunningAverageTest
{



    [Fact]
    public void RunningAverage_Construct_1()
    {
	RunningAverage avg = new RunningAverage();

	Assert.Equal(0, avg.Total);
	Assert.Equal(0, avg.Count);
	Assert.Equal(0, avg.Average(), 0.1);


    }

    [Fact]
    public void RunningAverage_Add_Total_Count_1()
    {
	RunningAverage avg = new RunningAverage();
	avg.Add(100.0);
	Assert.Equal(100.0, avg.Total, 0.1);
	Assert.Equal(1, avg.Count);
	Assert.Equal(100.0, avg.Average(), 0.1);


    }

    [Fact]
    public void RunningAverage_Add_Total_Count_2()
    {
	RunningAverage avg = new RunningAverage();

	avg.Add(100.0);
	avg.Add(200.0);
	avg.Add(300.0);
	Assert.Equal(600.0, avg.Total, 0.001);
	Assert.Equal(3, avg.Count);
	Assert.Equal(200, avg.Average(), 0.1);


    }

    [Fact]
    public void RunningAverage_Add_Total_Count_3()
    {
	RunningAverage avg = new RunningAverage();

	avg.Add(100.0);
	avg.Add(100.0);
	avg.Add(100.0);
	avg.Add(100.0);
	avg.Add(100.0);
	Assert.Equal(100.0, avg.Total, 0.001);
	Assert.Equal(5, avg.Count);
	Assert.Equal(100.0, avg.Average(), 0.1);


    }







}
