namespace C_Loops_and_Arrays_Assignments;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] numbers = new int[10];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] =rnd.Next(1, 101);
        }

        System.Console.WriteLine("Dizinin elemanlaarı: ");
        foreach (int num in numbers)
        {
            System.Console.WriteLine(num + " ");
        }
        System.Console.WriteLine();

        System.Console.WriteLine("Kendinden önceki vve sonraki elemanlardan büyük olanlar: ");
        for (int i = 1; i < numbers.Length - 1; i++)
        {
            if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
            {
                System.Console.WriteLine($"Dizi[{i}] = {numbers[i]} (Önceki: {numbers[i - 1]}, Sonraki: {numbers[i + 1]})");
            }
        }
    }
}
