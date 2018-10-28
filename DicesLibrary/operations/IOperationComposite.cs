using System;
using System.Collections.Generic;
using System.Text;

namespace DicesLibrary.operations
{
    public interface IOperationComposite : IOperationComponent
    {
        void AddChild(IOperationComponent component);
        bool RemoveChild(IOperationComponent component);
        ICollection<IOperationComponent> Children { get; }
    }
}
