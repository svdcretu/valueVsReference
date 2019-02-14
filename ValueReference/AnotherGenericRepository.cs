using System;
using System.Collections.Generic;
using System.Text;

using ValueReference.Contracts;
using ValueReference.ReferenceTypesExamples;

namespace ValueReference
{
    public class AnotherGenericRepository: IGenericRepository
    {
        public IList<IOpen> GetThingsToOpen()
        {
            var results = new List<IOpen>();

            results.Add(new LetterService());
            results.Add(new PostCardService());

            return results;
        }
    }
}
