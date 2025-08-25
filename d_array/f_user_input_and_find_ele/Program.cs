namespace user_input_and_find_ele;

class Program
{
    static void Main(string[] args)
    {
        int[] myNum = { 1, 3, 5, 7 };
        System.Console.WriteLine("Enter a number to find:");
        // int input = Convert.ToInt32(System.Console.ReadLine());
        int input = int.Parse(Console.ReadLine());
        bool found = false;
        foreach (var item in myNum)
        {
            if (item == input)
            {
                found = true;
                break;
            }
        }
        if (found)
        {
            System.Console.WriteLine("Number found...");
        }
        else
        {
            System.Console.WriteLine("Number not found...");
        }
    }
}   
