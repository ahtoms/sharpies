namespace AddingArrays;

public class AddingArrays
{

    public static int[] Join(int[] arrayA, int[] arrayB) {
        int[] newArray = new int[arrayA.Count() + arrayB.Count()];
        int offset = 0;
        for(int i = 0; i < arrayA.Count(); i++) {
            newArray[offset] = arrayA[i];
            offset++;
        }
        for(int i = 0; i < arrayB.Count(); i++) {
            newArray[offset] = arrayB[i];
            offset++;
        }

        return newArray;
    }

}
