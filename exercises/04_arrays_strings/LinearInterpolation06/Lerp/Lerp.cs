namespace Lerp;

public class Lerp
{

    public static float LinearInterpolation(int start, int end, float interp)
    {
        float res = 0;

        float length = end - start;
        float position = length * interp;
        res = start + position;

        return res;
    }

    public static (float, float) LinearInterpolation2D(
        int startX,
        int startY,
        int endX,
        int endY,
        float interp)
    {
        return (LinearInterpolation(startX, endX, interp),
                LinearInterpolation(startY, endY, interp));
    }

}
