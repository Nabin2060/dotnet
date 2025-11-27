namespace e_string_builder_remove;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder s = new StringBuilder("hello world",6);
        s.Remove(3,4);
        Console.WriteLine(s);
    }
}
