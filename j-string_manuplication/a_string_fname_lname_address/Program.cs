namespace a_string_fname_lname_address;

class Program
{
    static void Main(string[] args)
    {
        string fname = "Ram";
        string lname = "adh";
        string address = "bkt";
        System.Console.WriteLine(fname + " " + lname + " " + "lives in " + address);
        Console.WriteLine("{0} {1} lives in {2}", fname, lname, address);
    }
}
