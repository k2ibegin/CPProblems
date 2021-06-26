using System.IO;
using System;

class Result
{

    /*
     * Complete the 'closestNumber' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER a
     *  2. INTEGER b
     *  3. INTEGER x
     */

    public static int closestNumber(int a, int b, int x)
    {
            var aToThePowerB = Math.Pow(a, b);

            if (b < 0)
            {
                if(a == 1 && x == 1) return 1;

                return 0;
            }
            var rounded = (int)Math.Round(aToThePowerB / x, MidpointRounding.AwayFromZero);
            return rounded * x;
    }

}

namespace  CPWithMain
{
    class Solution
{
    public static void Main(string[] args)
    {
        var read = File.ReadLines("../../../input00.txt");

        foreach (var line in read)
        {
            var firstMultipleInput = line.TrimEnd().Split(' ');

            var a = Convert.ToInt32(firstMultipleInput[0]);

            var b = Convert.ToInt32(firstMultipleInput[1]);

            var x = Convert.ToInt32(firstMultipleInput[2]);

            var result = Result.closestNumber(a, b, x);
            Console.WriteLine(result);
        }
    }
}

}
