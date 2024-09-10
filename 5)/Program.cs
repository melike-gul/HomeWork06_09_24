namespace _5_;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] numbers = new int[100];
        int sreachNumber;

        for ( int i = 0; i <numbers.Length; i++)
        {
            numbers[i] = rnd.Next(1, 101);
        }
        System.Console.WriteLine("Bir sayı girin (1, 101)");
        sreachNumber = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Dizi:");
        foreach (int num in numbers)
        {
            System.Console.WriteLine(num + " ");
        }
        System.Console.WriteLine();

        int count = 0;
        System.Console.WriteLine("Sayı dizide bulunuyor. Pozisyonları: ");
        for(int i =0; i < numbers.Length; i++)
        {
            if (numbers[i] == sreachNumber)
            {
                System.Console.WriteLine(i + " ");
                count++;
            }
        }

        if (count > 0)
        {
            System.Console.WriteLine();
            System.Console.WriteLine($"Sayı dizide {count} kez bulunuyor.");
        }
        else
        {
            System.Console.WriteLine("Sayı dizide bulunmuyor.");
        }
    }
}
