namespace f_strinng_builder_replace;

using System.Text;
class Program
{
    static void Main(string[] args)
    {
        StringBuilder s = new StringBuilder("Hello sanothimi", 20);
        s.Replace("sanothimi", "kathmandu");
        Console.WriteLine(s);
    }
}
