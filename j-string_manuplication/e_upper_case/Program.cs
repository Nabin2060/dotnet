namespace e_upper_case;

class Program
{
    static void Main(string[] args)
    {
        string str = "hello";
        string str2 = str.ToUpper();
        System.Console.WriteLine("Original string : " + str);;
        Console.WriteLine("Converted string : " + str2);
    }
}
