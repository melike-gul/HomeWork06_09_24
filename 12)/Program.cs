namespace _12_;

class Program
{
    static void Main(string[] args)
    {
      int[] numbers = new int[100];
      Random rnd = new Random();
      for (int i = 0; i < numbers.Length; i++)
      {
        numbers[i] = rnd.Next(1, 21);
      }

      Dictionary<int, int> frequency = new Dictionary<int, int>();

      foreach (int number in numbers)
      {
        if (frequency.ContainsKey(number))
        {
            frequency[number]++;
        }else
        {
            frequency[number] = 1;
        }
      }
      int mostFrequentNumber = numbers[0];
      int maxCount = 0;
      foreach (var pair in frequency)
      {
        if (pair.Value > maxCount)
        {
            mostFrequentNumber = pair.Key;
            maxCount = pair.Value;
        }
      }
      System.Console.WriteLine($"Dizide en sık tekrar eden sayı:{mostFrequentNumber}");
      System.Console.WriteLine($"Bu sayı {maxCount} defa tekrar edildi.");
    }
}
