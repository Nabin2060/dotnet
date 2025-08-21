namespace a_class_object_method;

class Student
{

    public void Hello()
    {
        Console.WriteLine("Hello, World!");
    }
    static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.Hello();
        
    }
}
