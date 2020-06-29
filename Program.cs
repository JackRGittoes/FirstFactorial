using System;

class MainClass
{

    public static int FirstFactorial(int num)
    {

        if (num < 1)
        {
            return 1;
        }
        else if (num > 1)
        {
            return num * FirstFactorial(--num);
        }

        return num;
    }

    static void Main()
    {
        // keep this function call here
        Console.WriteLine(FirstFactorial(Convert.ToInt32(Console.ReadLine())));
    }

}