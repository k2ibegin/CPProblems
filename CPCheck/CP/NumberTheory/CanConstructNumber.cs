using System;
using System.Collections.Generic;
using System.Linq;

namespace CP
{
    public class CanConstructNumber
    {
        private List<int> digits = new List<int>();

        // Return "Yes" or "No" denoting whether you can construct the required number.
        public string CanConstruct(IEnumerable<int> a)
        {
            //Step1 : find digits
            foreach (var number in a)
            {
                CheckDigits(number);
            }

            //Step2: Find all possible numbers
            //https://stackoverflow.com/questions/9645582/how-to-get-all-possible-n-digit-numbers-that-can-be-formed-using-given-digits
            //https://mathinstructor.net/2018/09/how-to-check-if-the-given-number-is-divisible-by-any-number-from-2-to-11/
            return CheckDivisibilityBy3() ? "Yes" : "No";
        }

        private bool CheckDivisibilityBy3()
        {
            var sum = digits.Sum();
            return (sum % 3 == 0) ? true : false;
        }

        private void CheckDigits(int number)
        {
            do
            {
                var quotient = Math.DivRem(number, 10, out var rem);
                digits.Add(rem);
                number = quotient;
            } while (number > 0);
        }
    }
}