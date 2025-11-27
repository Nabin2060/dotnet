namespace c_string_concatenation;

class Program
{
    static void Main(string[] args)
    {
        string fname = "Ram";
        string lname = "adh";
        Console.WriteLine(string.Concat(fname + " " + lname));
    }
}
