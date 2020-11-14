using System;

namespace ArithmeticSequenceTask
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            if (count < 0 || count == 0)
            {
                throw new ArgumentException($"{nameof(count)} is less or equals zero");
            }

            if (number >= int.MaxValue || number <= int.MinValue)
            {
                throw new OverflowException(nameof(number));
            }

            var sum = 0;

            for (int i = 0; i < count; i++)
            {
                sum += number;

                for (int j = 0; j < i; j++)
                {
                    sum += add;
                }
            }

            return sum;
        }
    }
}
