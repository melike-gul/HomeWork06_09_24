namespace _9_;

class Program
{
    static void Main(string[] args)
    {
       int[] array = {1, -2, 3, 0, 5, -7, 8, -9, 10, -11 };
       System.Console.WriteLine("Orjinal Dizi: ");
       PrintArray(array);

       ReversePositiveNumbers(Array);

       System.Console.WriteLine("Pozitif Sayıları Ters Çevrilmiş Dizi:");
       PrintArray(array);
    }
}
