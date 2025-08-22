namespace c_array;

class Program
{
    static void Main(string[] args)
    {
        int[] myArr = { 2, 4, 5, 6 };

        //foreach loop
        // foreach (var item in myArr)
        // {
        //      System.Console.WriteLine(item);
        // }
        // Console.WriteLine("Hello, World!");

        // for loop
        // for (int i = 0; i < 5; i++)
        // for(int i = 0; i < myArr.Length; i ++)
        // {
        //     System.Console.WriteLine(myArr[i]);
        // }

        //sorting array
        // Array.Sort(myArr);
        // foreach (var item in myArr)
        // {
        //      System.Console.WriteLine(item);
        // }

        // char
        // char[] myCharr = { 'h', 't', 's', 'w' };
        // foreach (char item in myCharr)
        // {
        //     System.Console.WriteLine(item);
        // }

        //string
        string[] myCharr = { "hrjr", "ty5y" };
        foreach (string item in myCharr)
        {
            System.Console.WriteLine(item);
        }
    }
}
