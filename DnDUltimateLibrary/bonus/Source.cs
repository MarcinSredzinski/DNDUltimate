using System;
using System.Collections.Generic;
using System.Text;

namespace DnDUltimateLibrary.bonus
{
    public class Source
    {
        public string Name { get; }
        public bool StackableWithTheSame { get; }
        public Source(string name, bool isStackableWithTheSame)
        {
            Name = name;
            StackableWithTheSame = isStackableWithTheSame;
        }
    }
}
