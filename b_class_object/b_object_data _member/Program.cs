namespace b_object_data__member;
#nullable disable
class Student
{
    int roll;
    string name;

    static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.roll = 44;
        s1.name = "ram";
        Console.WriteLine("roll :"+ s1.roll);
        Console.WriteLine("roll :"+ s1.name);


    }
}
