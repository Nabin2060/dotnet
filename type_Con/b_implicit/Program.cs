namespace b_implicit;

class Program
{
    static void Main(string[] args)
    {
        // byte a = 256;
        byte a = 255;

        int b = a;
        System.Console.WriteLine("The byte value before implicit :" + a);
        System.Console.WriteLine("The int value after implicit ::" + b);
    }
}
