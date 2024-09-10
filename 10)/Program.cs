namespace _10_;

class Program
{
    static void Main(string[] args)
    {
       int[] originalArray = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100};

       int[] reverseArray = new int[originalArray.Length];

       for (int i = 0; i < originalArray.Length; i++)
       {
            reverseArray[i] = originalArray[originalArray.Length - 1 - i];
       }
       System.Console.WriteLine("Orijinal Dizi:");
       foreach (int num in originalArray)
       {
        System.Console.WriteLine(num + " ");
       }
       System.Console.WriteLine();

       System.Console.WriteLine("Ters Sıralanmış Dizi: ");
       foreach (int num in reverseArray)
       {
            System.Console.WriteLine(num + " ");
       }
       System.Console.WriteLine();
    }
}
