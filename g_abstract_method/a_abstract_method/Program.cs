// See https://aka.ms/new-console-template for more information

abstract class HelloNp
{
    public abstract void hi();
}
class Kathmandu: HelloNp
{
    public override void hi()
    {
        System.Console.WriteLine("Hello from Kathmandu");
    }
}

class Bhakt: Kathmandu
{
    public override void hi()
    {
        System.Console.WriteLine("Hello from Bhakt");
    }
}
class Progras
{
    static void Main(string[] args)
    {
        HelloNp h;
        h = new Kathmandu();
        h.hi();
        h = new Bhakt();
        h.hi();


    }
}