using System;
using System.Collections.Generic;

namespace ValueReference.ReferenceTypesExamples
{
    public class SomeCloneServices
    {
        public SomeCloneServices()
        {
            
        }

        public List<ICloneable> CreateClones(List<ICloneable> itemsToClone)
        {
            var results = new List<ICloneable>();

            foreach (ICloneable cloneable in itemsToClone)
            {
                object clone = cloneable.Clone();
                results.Add((ICloneable)clone);
            }

            return results;
        }

        public object CreateClone(ICloneable objectToClone)
        {
            return objectToClone.Clone();
        }
    }
}
