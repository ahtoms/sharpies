namespace RandomSelect;

public class RandomSelect
{

    public static int? Select(int[] numbers) {

        if(numbers.Count() == 0) { return null; }

        Random rand = new Random();

        int v = numbers[rand.NextInt64() % numbers.Count()];

        return v;
    }

}
