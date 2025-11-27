// See https://aka.ms/new-console-template for more information


// See https://aka.ms/new-console-template for more information
public delegate void MyNumDel(int num);
class myNum
{
    
    public static void square(int num)
    {
        System.Console.WriteLine("Hello :  " + num, num * num);
    }
    public static void cube(int num)
    {
        System.Console.WriteLine("Hello :  " + num, num * num * num);
    }
}
class Progr : myNum
{
    static void Main(string[] args)
    {
        MyNumDel del = new square;
        del(5);
        myNum del2 = new cube;
        del2.Invoke(4);

    }
}
