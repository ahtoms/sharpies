namespace RowMajor;

public class RowMajorArray
{

    private int[] array;
    public int Width { get; private set; }
    public int Height { get; private set; }

    public RowMajorArray(int[] array, int width, int height) {
        Width = width;
        Height = height;
        this.array = array;
    }

    public int Get(int x, int y) {

        return array[(Width * y) + x];
    }

    public void Set(int x, int y, int v) {
        array[(Width * y) + x] = v;
    }



}
