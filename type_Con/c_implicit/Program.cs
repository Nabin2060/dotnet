namespace c_implicit;

class Program
{
    static void Main(string[] args)
    {
        byte a = 33;
        int b = a;
        long c = b;

        System.Console.WriteLine("Byte a =" + a);
        System.Console.WriteLine("int b =" + b);
        System.Console.WriteLine("long c =" + c);

    }
}
