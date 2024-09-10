using System.Runtime.InteropServices;

namespace _16_;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int inputNumber;
        int sum = 0;
        do
        {
            System.Console.WriteLine("Bir sayı girin (Durdurmak için 0 girin): ");
            inputNumber = int.Parse(Console.ReadLine());

            if(inputNumber != 0)
            {
                numbers.Add(inputNumber);
                sum += inputNumber;
            }
        }while(inputNumber != 0);
        
        if (numbers.Count > 0)
        {
            double average = sum / (double)numbers.Count;
            System.Console.WriteLine("Dizideki sayılar:");
            foreach (int number in numbers)
            {
                System.Console.WriteLine(number + " ");
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"Ortalama: {average}");
        }
        else
        {
            System.Console.WriteLine("Hiç sayı girilmedi.");
        }
    }
}
