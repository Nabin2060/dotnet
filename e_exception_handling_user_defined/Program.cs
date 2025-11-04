// See https://aka.ms/new-console-template for more information

// class MyException : Exception
// {
//     public MyException(string str)
//     {
//         System.Console.WriteLine(str);
//     }
// }

// class Program
// {
//     static void Main(string[] args )
//         {
//         try
//         {
//             throw new MyException("This is a user-defined exception");
//         }
//         catch (MyException ex)
//         {
//             System.Console.WriteLine("Caught user-defined exception: " + ex.Message);
//         }
//     }
// }

// voter age check example

class InvalidVoters : Exception
{
    public InvalidVoters(string str)
    {
        System.Console.WriteLine(str);
    }
}

class Programs
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Enter your age :");
        int age = int.Parse(Console.ReadLine());
        try
        {
            if (age <18)
            {
                throw new InvalidVoters("You are not eligible to vote");
            } else
            {
                Console.WriteLine("youre eligible to vote");
            }
        } catch (InvalidVoters err)
        {
            System.Console.WriteLine("Error found :" + err. Message);
        }
    }
}