namespace f_string_copy;

class Program
{
    static void Main(string[] args)
    {
        string str = "Hello";
        string str2 = string.Copy(str);
        System.Console.WriteLine("Original string :" + str);;
        Console.WriteLine("Converted string :" + str2);
    }
}
