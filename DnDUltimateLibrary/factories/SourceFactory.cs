using DnDUltimateLibrary.bonus;
using DnDUltimateLibrary.exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DnDUltimateLibrary.factories
{
    public class SourceFactory
    {
        IDictionary<string, Source> sources = new Dictionary<string, Source>();

        public Source Create(string name, bool isStackableWithTheSame = false)
        {
            if (sources.ContainsKey(name))
            {
                if (sources[name].StackableWithTheSame != isStackableWithTheSame)
                {
                    throw new BadSourceException();
                }
            }
            else
            {
                sources.Add(name, new Source(name, isStackableWithTheSame));
            }
            
            return sources[name];
        }

    }
}
