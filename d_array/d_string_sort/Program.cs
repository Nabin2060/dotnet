namespace string_sort;

class Program
{
    static void Main(string[] args)
    {
        string[] myChar = { "ram", "hari", "ashok" };
        int len = myChar.Length;
        // sort 
        // Array.Sort(myChar);

        //
        // reverse 
        // Array.Reverse(myChar);
        // foreach (var item in myChar)
        // {
        //     Console.WriteLine(item);
        // }

        // used for loop
        for (int i = 0; i < len; i++)
        {
            System.Console.WriteLine("Name {0} is = {1}", i + 1, myChar[i]);
        }
        // Array.Sort(myChar);
        Array.Reverse(myChar);
        System.Console.WriteLine("After sorting:");
            for (int i = 0; i < len; i++)
            {
                System.Console.WriteLine("Name {0} is = {1}", i + 1, myChar[i]);
            }
        
    }
}
