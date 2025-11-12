// See https://aka.ms/new-console-template for more information
public delegate void MyDelegate(string name);

class Progra
{
    public static void displayName(string name)
    {
        System.Console.WriteLine("Hello :  " + name);
    }
    static void Main(string[] args)
    {
        MyDelegate del = new MyDelegate(displayName);
        del("Dotnet Delegate");
    }
}
