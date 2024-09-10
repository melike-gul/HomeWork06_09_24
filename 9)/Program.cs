using System.Globalization;

namespace _9_;

class Program
{
    static void Main(string[] args)
    {
       int[] numbers = {1, -2, 3, 0, 5, -7, 8, -9, 10, -11 };
       System.Console.WriteLine("Orjinal Dizi: ");
       foreach (int num in numbers)
       {
        System.Console.WriteLine(num + "" );
       }
       System.Console.WriteLine();

       List<int> possitiveNumbers = new List<int>();

       foreach (int num in numbers)
       {
            if (num > 0)
            {
                possitiveNumbers.Add(num);
            }
       }

       possitiveNumbers.Reverse();

       int index = 0;
       for (int i = 0; i < numbers.Length; i++)
       {
        if (numbers[i] > 0)
        {
            numbers[i] = possitiveNumbers[index++];
        }
       }

       System.Console.WriteLine("Pozitif sayıları ters çervilmiş Dizi: ");
       foreach (int num in numbers)
       {
            System.Console.WriteLine(num + " ");
       }
       System.Console.WriteLine();
    }
}
