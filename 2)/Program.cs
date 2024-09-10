using System.Globalization;

namespace _2_;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[10];
        int[] evenNumbers = new int[10];
        int evenCount = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Lütfen {i + 1} . sayıyı giriniz:");
            numbers[i] = int.Parse(Console.ReadLine());

            if (numbers[i] % 2 == 0)
            {
                evenNumbers[evenCount] = numbers[i];
                evenCount++;
            }
        }
        Array.Resize(ref evenNumbers, evenCount);

        Array.Sort(evenNumbers);

        System.Console.WriteLine("Çift sayılar (küçükten büyüğe)");
        foreach (int even in evenNumbers)
        {
            System.Console.WriteLine(even);
        }
    }
}
