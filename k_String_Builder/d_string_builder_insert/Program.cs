namespace d_string_builder_insert;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder("Hello",20);
        sb.Insert(2, "Nepal");

        Console.WriteLine(sb);
    }
}
