namespace _14_;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[20];
        Random rnd = new Random();
        
        for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rnd.Next(1, 101);
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            if (number % 3 == 0)
            {
                sum += number;
            }
        }
        System.Console.WriteLine("Toplam: ");
        string sumStr = sum.ToString();
        for (int i = 0; i < sumStr.Length; i++)
        {
            System.Console.WriteLine(sumStr[i]);
            if((i + 1) % 5 == 0 && i != sumStr.Length - 1)
            {
                System.Console.Write(" ");
            }
        }
        System.Console.WriteLine();
    }
}
