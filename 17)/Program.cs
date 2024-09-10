using System.Globalization;

namespace _17_;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 3, 5, 1, 9 , 12, 8, 7 ,12 , 6, 11};
        int max1 = int.MinValue;
        int max2 = int.MaxValue;
        
        for (int i = 0; i < numbers.Length; i++)
        {
            if(numbers[i] > max1)
            {
                max2 = max1;
                max1 = numbers[i];
            }
            else if (numbers[i] > max2 && numbers[i] != max1)
            {
                max2 = numbers[i];
            }
        }
        if (max2 != int.MinValue)
        {
            System.Console.WriteLine($"En büyük sayı: {max1}");
            System.Console.WriteLine($"İkinci en büyük sayı: {max2}");
        }
        else
        {
            System.Console.WriteLine("Yeterli sayıda farklı sayı bulunmamaktadır. ");
        }
    }
}
