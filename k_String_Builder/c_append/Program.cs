namespace c_append;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder("This  :",20);
        sb.Append("This is C# programming language");
        sb.Append("hi");
        sb.AppendLine("hello");
        sb.Append("welcome to c#");
        Console.WriteLine(sb);
    }
}
