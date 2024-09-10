namespace _11_;

class Program
{
    static void Main(string[] args)
    {
       System.Console.WriteLine("Bir cümle girin: ");
       string sentence = Console.ReadLine();

       string[] words = sentence.Split(' ');

       int index = words.Length - 1;
       System.Console.WriteLine("Cümledeki kelimeleri tersten: ");
       while (index>= 0)
       {
        System.Console.WriteLine(words[index] + " ");
        index--;
       }
       System.Console.WriteLine();
    }
}
