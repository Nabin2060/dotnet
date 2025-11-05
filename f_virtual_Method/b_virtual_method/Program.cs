// See https://aka.ms/new-console-template for more information
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;



class Shape
{
    protected int width, height;
    public Shape(int a = 0, int b = 0)
    {
        width = a;
        height = b;
        Console.WriteLine("Shape constructor called");
    }
    public virtual int area()
    {
        return 0;
    }

}
class Rectangle : Shape
{
    public Rectangle(int a = 0, int b = 0) : base(a, b){}
    public override int area()
    {
        System.Console.WriteLine("Rectangle area:");
        return (width * height);
    }

}
class Trangle : Shape
{
    public Trangle(int a = 0, int b = 0) : base(a, b) { }
    public override int area()
    {
        System.Console.WriteLine("Tringle:");
        return (width * height) / 2;
    }
}
class Caller
{
    public void CallArea(Shape sh)
    {
        int ar;
        ar = sh.area();
        System.Console.WriteLine("Area: {0}", ar);
    }
}
 class P
{
    static void Main(string[] args)
    {
        Caller obj = new Caller();
        Rectangle rec = new Rectangle(11, 44);
        Trangle tra = new Trangle(44, 65);
        obj.CallArea(rec);
        obj.CallArea(tra);
    }
}