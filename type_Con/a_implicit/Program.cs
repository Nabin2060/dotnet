namespace a_implicit;

class Program
{
    static void Main(string[] args)
    {
        byte a = 10;
        float b = a;
        System.Console.WriteLine("The byte value before implicit :" + a); 
        System.Console.WriteLine("The float value after implicit ::" + b); 

    }
}
