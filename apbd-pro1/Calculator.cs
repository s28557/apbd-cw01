public class Calculator
{
    public static double FindAvg(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            throw new ArgumentException("Array must not be null or empty");
        }

        double sum = 0;
        foreach (int num in nums)
        {
            sum += num;
        }

        return sum / nums.Length;
    }
}