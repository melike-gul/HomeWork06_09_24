namespace _3_;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] numbers = new int[10];
        int[] positiveNumbers = new int[10];
        int[] negativeNumbers = new int[10];

        int posCount = 0;
        int negCount = 0;
        int index = 0;

        while (index < numbers.Length)
        {
            numbers[index]= rnd.Next(-50, 51);
            index++;
        }

        System.Console.WriteLine("Orjinal dizi:");
        foreach(int num in numbers)
        {
            System.Console.WriteLine(num + " ");
        }
        System.Console.WriteLine();

        index = 0;
        while (index < numbers.Length)
        {
            if (numbers[index] > 0)
            {
                positiveNumbers[posCount] = numbers[index];
                posCount++;
            }else if (numbers[index] < 0)
            {
                negativeNumbers[negCount] = numbers[index];
                negCount++;
            }
            index++;
        }

        System.Console.WriteLine("Pozitif sayılar: ");
        for (int i = 0; i < posCount; i++)
        {
            System.Console.WriteLine(positiveNumbers[i] + " ");
        }
        System.Console.WriteLine();

        System.Console.WriteLine("Negatif sayılar: ");
        for (int i = 0; i < negCount; i++)
        {
            System.Console.WriteLine(negativeNumbers[i] + " ");
        }
        System.Console.WriteLine();
    }
}