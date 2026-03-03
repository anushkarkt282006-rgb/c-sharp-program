using system;

class program
{
    static void main()
    {
        int[] numbers = new int[5];
        for (int i = 0; i < 5; i++)
        {
            console.write($"enter number {i + 1}: ");
            numbers[i] = int.parse(console.readline());
        }

        int sum = 0;
        for (int i = 0; i < 5; i++)
        {
            sum += numbers[i];
        }

        double average = (double)sum / numbers.length;
        console.writeline($"sum: {sum}");
        console.writeline($"average: {average}");
    }
}