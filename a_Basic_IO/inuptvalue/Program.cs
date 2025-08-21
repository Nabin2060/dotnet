namespace inuptvalue;

class Program
{
    
    static void Main(string[] args){
        Console.WriteLine("Enter a value a:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a value b:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Sum {0} and {1}", a,b, (a+b));
    }
}

