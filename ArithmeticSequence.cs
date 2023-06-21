using System;

namespace ArithmeticSequenceTask
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            if (count < 0)
            {
                throw new ArgumentException("Count must be greater than or equal to zero.");
            }

            if ((add > 0 && number > int.MaxValue - (add * (count - 1))) ||
                (add < 0 && number < int.MinValue - (add * (count - 1))))
            {
                throw new OverflowException("Arithmetic sequence sum exceeds the range of int data type.");
            }

            int sum = count * ((2 * number) + (add * (count - 1))) / 2;
            return sum;
        }
    }
}
