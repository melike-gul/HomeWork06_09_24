namespace _15_;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 4, 1, 7, 6, 2, 9, 5, 8, 3, 10};

        int[] oddNumbers = numbers.Where(n => n % 2 !=0).ToArray();
        int[] evenNumbers = numbers.Where(n => n % 2 == 0).ToArray();

        Array.Sort(oddNumbers);

        int[] result = new int[numbers.Length];
        int oddIndex = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if(numbers[i] % 2 != 0)
            {
                result[i] = oddNumbers[oddIndex++];
            }
            else
            {
                result[i] = numbers[i];
            }
        }
        System.Console.WriteLine("Sıralanmış dizi:");
        foreach (int number in result)
        {
            System.Console.WriteLine(number + " ");
        }
    }
}
