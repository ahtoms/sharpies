namespace MinSearch;

public class MinSearch
{

    public static int? Find(int[] numbers) {
        int? currentMin = null;

        for(int i = 0; i < numbers.Count(); i++) {
            if(currentMin == null) {
                currentMin = numbers[i];
            }
            if(currentMin > numbers[i]) {
                currentMin = numbers[i];
            }
        }

        return currentMin;
    }

}
