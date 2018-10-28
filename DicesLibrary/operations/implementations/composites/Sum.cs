using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DicesLibrary.operations.implementations.composites
{
    public class Sum : IOperationComposite
    {
        public ICollection<IOperationComponent> Children { get; }

        public Sum()
        {
            Children = new List<IOperationComponent>();
        }

        public void AddChild(IOperationComponent component)
        {
            Children.Add(component);
        }

        public decimal ExecuteOperation()
        {
            return Children.Sum(e => e.ExecuteOperation());
        }

        public bool RemoveChild(IOperationComponent component)
        {
            return Children.Remove(component);
        }
    }
}
