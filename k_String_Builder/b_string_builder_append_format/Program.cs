namespace b_string_builder_append_format;

using System.Runtime.Intrinsics.X86;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder("This mobile price :");
        sb.AppendFormat("{0:c}", 20000);
        // sb.Append( 20000); only appends the number without formatting

        Console.WriteLine(sb);
    }
}
