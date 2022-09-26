using System;

namespace CP
{
    public class ClosestNumber
    {
        public int closestNumberMyApproach(int a, int b, int x)
        {
            var remainder = 0;
            var numerator = Math.Pow(a, b);

            if (numerator < 0.5)
            {
                return 0;
            }

            if (numerator < 1 && numerator >= 0.5)
            {
                return 1;
            }

            var wholeNumerator = (int) numerator;
            var quotient = Math.DivRem(wholeNumerator, x, out remainder);

            if (quotient > 0)
            {
                if (remainder == 0)
                {
                    return wholeNumerator;
                }

                if (remainder > 0)
                {
                    var above = quotient + 1;
                    var aboveNumber = above * x;
                    var belowNumber = quotient * x;
                    var aboveNumberDistance = Math.Abs(aboveNumber - numerator);
                    var belowNumberDistance = Math.Abs(belowNumber - numerator);

                    return aboveNumberDistance >= belowNumberDistance ? belowNumber : aboveNumber;
                }
            }

            return 0;
        }

        //actual solution that succeeds for all test cases
        public int closestNumber(int a, int b, int x)
        {
            var aToThePowerB = Math.Pow(a, b);

            if (b < 0)
            {
                if(a == 1 && x == 1) return 1;

                return 0;
            }

            double div = aToThePowerB / x;
            var fullRound = Math.Round(div, 1,  MidpointRounding.ToEven);
            var rounded = (int)Math.Round(div, MidpointRounding.AwayFromZero);
            Console.WriteLine("ss");
            return rounded * x;
        }
    }
}