namespace _6_;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] numbers = new int[100];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rnd.Next(1, 101);
        }

        int min = numbers[0];
        int max = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        System.Console.WriteLine("Dizi");
        foreach (int num in numbers)
        {
            System.Console.WriteLine(num + " ");
        }
        Console.WriteLine();
        Console.WriteLine($"En küçük sayı: {min}");
        Console.WriteLine($"En küçük sayı: {max}");
    }
}
