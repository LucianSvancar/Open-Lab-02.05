using System;

namespace Open_Lab_02._05
{
    public class Calculator
    {
        public bool DivisibleByFive(int number)
        {
            int num = number % 5 ;
            bool Q = num == 0;
            return Q;

        }
    }
}
