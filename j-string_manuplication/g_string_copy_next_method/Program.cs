namespace  g_string_copy_next_method;

class Program
{
    static void Main(string[] args)
    {
        string str = "Hello";
        // string str2 = string.Copy(str);
        string str2 = new string(str);
        System.Console.WriteLine("Source string :" + str);;
        Console.WriteLine("Copoied string :" + str2);
    }
}
