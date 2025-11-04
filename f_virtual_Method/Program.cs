// See https://aka.ms/new-console-template for more information

class SuperClass
{
    public virtual int add(int a, int b)
    {
        return a + b;
    }
}
class subClass : SuperClass
{
    public override int add(int a, int b)
    {
        return (a + b + 33);
    }
}

class Programss
{
    static void Main(string[] args)
    {
        SuperClass obj = new subClass();
        System.Console.WriteLine("The new redefined sum = " + obj.add(220,333));
    }
}
