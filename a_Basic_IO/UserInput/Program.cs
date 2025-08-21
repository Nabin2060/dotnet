namespace UserInput;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name:");
        string fname = Console.ReadLine();
        Console.WriteLine("Enter your Last name:");
        string Lname = Console.ReadLine();
        Console.WriteLine("The full name is {0} {1}.", fname,Lname);
    }
}
