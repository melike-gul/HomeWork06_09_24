using System.Data;

namespace _4_;

class Program
{
    static void Main(string[] args)
    {
       Random rnd = new Random();
       int[] numbers = new int[100];
       Dictionary<int, List<int>> occurrences = new Dictionary<int, List<int>>();

       for (int i = 0; i < numbers.Length; i++)
       {
            numbers[i] = rnd.Next(1,101);
       }

       System.Console.WriteLine("Dizi: ");
       foreach ( int num in numbers)
       {
        System.Console.Write(num + " ");
       }
       System.Console.WriteLine();

       System.Console.WriteLine("Kontrol edilen elmanlar (for döngüsü ile): ");
        for ( int i = 0; i < numbers.Length; i++)
        {
            int currentNum = numbers[i]
            if (occurrences.ContainsKey(currentNum))
            {
                occurrences[currentNum].Add(i);
            }else
            {
                occurrences[currentNum] = new List<int> { i };
            }
        }
        foreach (var entry in occurrences)
        {
            if (entry.Value.Count > 1)
            {
                System.Console.Write($"Elaman {entry.Key} pozisyonlarda tekrar ediyor: ");
                foreach (int pos in entry.Value)
                {
                    System.Console.WriteLine(pos + " ");
                }
                System.Console.WriteLine();
            }
        }
        System.Console.WriteLine("Tekrar eden elemanlar (foreach döngüsü ile)");
        occurrences.Clear();

        foreach (int currentNum in numbers)
        {
           if (occurrences.ContainsKey(currentNum))
           {
            occurrences[currentNum].Add(Array.IndexOf(numbers, currentNum));
           }
           else
           {
            occurrences[currentNum] = new List<int> {Array.IndexOf(numbers, currentNum)};
           }

           foreach (var entry in occurrences)
           {
                if (entry.Value.Count > 1)
                {
                    System.Console.Write($"Eleman {entry.Key} pozisyonlarda tekrar ediyor: ");
                    foreach (int pos in entry.Value)
                    {
                        System.Console.WriteLine(pos + " ");
                    }
                    System.Console.WriteLine();
                }
           }
        }
    }
}
