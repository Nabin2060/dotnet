namespace two_d_array;

class Program
{
    static void Main(string[] args)
    {
        int[,] myArr = { { 1, 3, 5, 7 }, { 5, 44, 6, 8 } };
        System.Console.WriteLine(myArr[1, 2]);

        // use foreach
        foreach (var item in myArr)
        {
            System.Console.WriteLine(item);
        }
        
    }
}
