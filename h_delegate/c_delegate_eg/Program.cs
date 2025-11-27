// See https://aka.ms/new-console-template for more information
public delegate int MyDeleg(int num);
class Prr
{
    public static int num;
    public static int AddNum(int a)
    {
        num += a;
        return num;
    }
    public static int MulNum(int a)
    {
        num *= a;
        return num;
    }
    public static int GetNum()
    {
        return num;
    }
    static void Main(string[] args)
    {
        System.Console.WriteLine("Add: {0}", AddNum(10));
        System.Console.WriteLine("Add: {0}", AddNum(20));
        System.Console.WriteLine("Mul: {0}", MulNum(10));
        System.Console.WriteLine("Get: {0}", GetNum());

        MyDeleg del = new MyDeleg(AddNum);
        del.Invoke(4);
        MyDeleg del2 = new MyDeleg(MulNum);
        del(5);

        

    }


}