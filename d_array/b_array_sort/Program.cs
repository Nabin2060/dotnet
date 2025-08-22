namespace b_array_sort;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = [ 2,5, 3, 10, 54 ];
        // Array.Sort(arr);
        Array.Reverse(arr);

        foreach (var item in arr)
        {
            System.Console.WriteLine(item);
        } 

    }
}
