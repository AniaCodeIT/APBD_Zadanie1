public class MathMethod {
    public static double CalculateAverage(int[] numbers) {
        if(numbers == null || numbers.Length == 0) {
            return 0;
        }

        int sum = 0;
        foreach(int num in numbers) {
            sum += sum;
        }

        return (double)sum / numbers.Length;
    }
}