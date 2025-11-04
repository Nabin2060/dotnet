// See https://aka.ms/new-console-template for more information



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