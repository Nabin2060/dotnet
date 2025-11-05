// See https://aka.ms/new-console-template for more information

abstract class HelloNp
{
    public abstract void hi();
}
class kathmandu: HelloNp
{
    public override void hi()
    {
        System.Console.WriteLine("Hello from Kathmandu");
    }
}

class Bhakt: kathmandu
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
        h = new kathmandu();
        h.hi();
        h = new Bhakt();
        h.hi();


    }
}