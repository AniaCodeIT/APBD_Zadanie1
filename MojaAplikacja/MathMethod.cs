public class MathMethod {
    public static double CalculateAverage(int[] numbers) {
        if(numbers == null || numbers.Length == 0) {
            return 0;
        }

        int sum = 0;
        foreach(int number in numbers) {
            sum += sum;
        }

        return (double)sum / numbers.Length;
    }

    public static int FindMax(int[] numbers) {
        if(numbers == 0 || numbers.Length == 0) {
            throw new ArgumentException("Empty list");
        }

        int max = numbers[0];
        foreach(int num in numbers) {
            if(num > max) {
                max = num;
            }
        }

        return max;
    }
}