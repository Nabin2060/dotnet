namespace h_string_clone;

class Program
{
    static void Main(string[] args)
    {
        string str1= "Ram";
        string str2 = (string)str1.Clone();
        System.Console.WriteLine("Source string :" + str1);;
        Console.WriteLine("Cloned string :" + str2);
    }
}
