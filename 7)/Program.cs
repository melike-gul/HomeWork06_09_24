namespace _7_;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] numbers = new int[50];

        for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rnd.Next(1, 101);
        }

        int sumOfEvens = 0;
       

        foreach (int num in numbers)
        {
            if(num % 2 == 0)
            {
                sumOfEvens += num;
            }
        }
        System.Console.WriteLine("Dizi: ");
        foreach (int num in numbers)
        {
            System.Console.WriteLine(num + " ");
        }
        System.Console.WriteLine();
        System.Console.WriteLine($"Çift sayıların toplamı: {sumOfEvens}");
    }
}
