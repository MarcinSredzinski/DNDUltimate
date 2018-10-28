using System;
using System.Collections.Generic;
using System.Text;

namespace DicesLibrary.operations.implementations.leaves
{
    class Constant : IOperationLeaf
    {
        decimal number;

        public Constant(decimal number)
        {
            this.number = number;
        }

        public decimal ExecuteOperation()
        {
            return number;
        }
    }
}
