namespace ListIntersection.Test;

public class ListIntersectionTest
{
    [Fact]
    public void ListIntersection_Empty_Lists_Test()
    {

	    List<int> A = new List<int>() { };
	    List<int> B = new List<int>() { };
	    List<int> result = ListIntersection.Intersection(A, B);
	    List<int> answer = new List<int>() { };

	    Assert.Equals(answer.Count(), result.Count());
	    Assert.NotNull(result);
	    Assert.Equal(answer, result);
    }

    [Fact]
    public void ListIntersection_Single_Lists_Test()
    {

	    List<int> A = new List<int>() { 1 };
	    List<int> B = new List<int>() { 1 };
	    List<int> result = ListIntersection.Intersection(A, B);
	    List<int> answer = new List<int>() { 1 };

	    Assert.Equals(answer.Count(), result.Count());
	    Assert.NotNull(result);
	    Assert.Equal(answer, result);
    }


    [Fact]
    public void ListIntersection_Single_With_3_Elements_Each()
    {

	    List<int> A = new List<int>() { 1, 2, 3 };
	    List<int> B = new List<int>() { 4, 2, 5 };
	    List<int> result = ListIntersection.Intersection(A, B);
	    List<int> answer = new List<int>() { 2 };

	    Assert.Equals(answer.Count(), result.Count());
	    Assert.NotNull(result);
	    Assert.Equal(answer, result);
    }

    [Fact]
    public void ListIntersection_Intersection_1_No_Overlap()
    {

	    List<int> A = new List<int>() { 1, 2, 3 };
	    List<int> B = new List<int>() { 4, 5, 6 };
	    List<int> result = ListIntersection.Intersection(A, B);
	    List<int> answer = new List<int>() {  };

	    Assert.Equals(answer.Count(), result.Count());
	    Assert.NotNull(result);
	    Assert.Equal(answer, result);
    }

    [Fact]
    public void ListIntersection_Intersection_1_Full_Overlap()
    {

	    List<int> A = new List<int>() { 1, 2, 3 };
	    List<int> B = new List<int>() { 3, 2, 1 };
	    List<int> result = ListIntersection.Intersection(A, B);
	    List<int> answer = new List<int>() { 1, 2, 3 };

	    Assert.NotNull(result);
	    Assert.Equals(answer.Count(), result.Count());
	    for(int i = 0; i < answer.Count(); i++) {
    		 Assert.True(result.Contains(answer[i]));
	    }
    }

    [Fact]
    public void ListIntersection_Intersection_1_Overlap()
    {

	    List<int> A = new List<int>() { 1, 2, 5 };
	    List<int> B = new List<int>() { 0, 2, 1 };
	    List<int> result = ListIntersection.Intersection(A, B);
	    List<int> answer = new List<int>() { 1, 2 };

	    Assert.NotNull(result);
	    Assert.Equals(answer.Count(), result.Count());
	    for(int i = 0; i < answer.Count(); i++) {
    		 Assert.True(result.Contains(answer[i]));
	    }
    }

    [Fact]
    public void ListIntersection_Intersection_2_Overlap()
    {

	    List<int> A = new List<int>() { 1, 2, 3, 8, 4 };
	    List<int> B = new List<int>() { 4, 5, 6, 3, 7 };
	    List<int> result = ListIntersection.Intersection(A, B);
	    List<int> answer = new List<int>() { 3, 4 };

	    Assert.NotNull(result);
	    Assert.Equals(answer.Count(), result.Count());
	    for(int i = 0; i < answer.Count(); i++) {
    		 Assert.True(result.Contains(answer[i]));
	    }
    }

    [Fact]
    public void ListIntersection_Intersection_Duplicate()
    {

	    List<int> A = new List<int>() { 1, 2, 3, 8, 4, 3 };
	    List<int> B = new List<int>() { 4, 5, 6, 3, 7 };
	    List<int> result = ListIntersection.Intersection(A, B);
	    List<int> answer = new List<int>() { 3, 4 };

	    Assert.NotNull(result);
	    Assert.Equals(answer.Count(), result.Count());
	    for(int i = 0; i < answer.Count(); i++) {
    		 Assert.True(result.Contains(answer[i]));
	    }
    }


}
