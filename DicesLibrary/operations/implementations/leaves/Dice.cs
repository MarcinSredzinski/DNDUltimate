using System;
using System.Collections.Generic;
using System.Text;

namespace DicesLibrary.operations.implementations.leaves
{
    public class Dice : IOperationLeaf
    {
        int _throwsCount;
        int _sidesAmount;

        public Dice(int throwsCount, int sidesAmount)
        {
            _throwsCount = throwsCount;
            _sidesAmount = sidesAmount;
        }

        public decimal ExecuteOperation()
        {
            decimal sum = 0;
            for (int i = 0; i < _throwsCount; i++)
            {
                sum += RandomFactory.RandomGenerator.Next(_sidesAmount);
            }
            return sum;
        }


    }
}
