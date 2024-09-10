namespace _8_;

class Program
{
    static void Main(string[] args)
    {
       Random rnd = new Random();
       int[] numbers = new int[10];

       for(int i =0; i < numbers.Length; i++)
       {
        numbers[i] = rnd.Next(1, 101);
       }

       System.Console.WriteLine("Orjinal Dizi:");
       foreach (int num in numbers)
       {
            System.Console.WriteLine(num + " ");
       }
       System.Console.WriteLine();

       System.Console.WriteLine("Bir sayı girin: ");
       int inputNumber = int.Parse(Console.ReadLine());

       bool found = false;
       foreach (int num in numbers)
       {
        if (num == inputNumber)
        {
            found = true;
            break;
        }
       }

       if(!found)
       {
        Array.Sort(numbers);

        int[] newNumbers = new int[numbers.Length + 1],
        bool inserted = false;
        int j = 0;

        for ( int i = 0; i < newNumbers.Length; i++)
        {
            if (i < numbers.Length && ! inserted && inputNumber < numbers[i])
            {
                newNumbers[i] = inputNumber;
                inserted = true;
            }
            if (i < numbers.Length)
            {
                newNumbers[i + (inserted ? 1 : 0)] = numbers[j++];
            }
        }
        System.Console.WriteLine("Yeni Dizi: ");
        foreach (int num in newNumbers)
        {
            System.Console.WriteLine(num + " ");
        }
        System.Console.WriteLine();
       }else 
       {
            System.Console.WriteLine($"Girdiğiniz sayı ({inputNumber}) dizide bulunuyor.");
       }
    }
}
