namespace i_string_compare;

class Program
{
    static void Main(string[] args)
    {
        string str1= "Ram";
        string str2 = "hello";
        string str3 = "hello";
        string str4= "ram";

;
        System.Console.WriteLine(string.Compare(str1, str2));
        System.Console.WriteLine(string.Compare(str2, str3));
        System.Console.WriteLine(string.Compare(str1, str4));
    }
}
