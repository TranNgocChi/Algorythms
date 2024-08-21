using Array;

class Program
{
    static void Main(string[] args)
    {
        var x = TwoSum.Solution(new int[] { 1, 2, 3, 4 }, 5);
        foreach (int i in x)
        {
            Console.WriteLine(i);
        }
    }
}