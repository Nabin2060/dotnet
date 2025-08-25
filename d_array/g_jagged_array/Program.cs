namespace f_jagged_array;

class Program
{
    static void Main(string[] args)
    {
        int[][] myArr = new int[4][];
        myArr[0] = new int[2] { 1, 3 };
        myArr[1] = new int[4] { 1, 3,4,6};
        myArr[2] = new int[5] { 1, 3,6,8,2 };
        myArr[3] = new int[1] { 1 };


        foreach (int[] i in myArr)
        {
            foreach (int iteam in i)
            {
                System.Console.WriteLine(iteam);
            }
        }
    }
}
