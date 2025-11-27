namespace d_lower_case;

class Program
{
    static void Main(string[] args)
    {
        string str = "Hello";
        string str2 = str.ToLower();
        System.Console.WriteLine("Original string :" + str);;
        Console.WriteLine("Converted string :" + str2);
    }
}
