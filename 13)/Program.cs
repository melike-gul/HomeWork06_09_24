using System.Xml.Schema;

namespace _13_;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        int sum = 0;
        foreach (int number in numbers)
        {
            if (number % 2 !=0)
            {
                sum += number;
            }
        }
        if (sum % 2 == 0)
        {
            System.Console.WriteLine($"Toplam çift sayı: {sum}");
        }
        else
        {
            System.Console.WriteLine($"Toplam tek sayı: {sum}");
        }
    }
}
