public class Calculator
{
    public static double FindAverage(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            throw new ArgumentException("Array must not be null or empty");
        }

        double average = nums.Average();

        return average;
    } 

    public static int FindMax(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            throw new ArgumentException("Array must not be null or empty");
        }

        return nums.Max();
    }
}
