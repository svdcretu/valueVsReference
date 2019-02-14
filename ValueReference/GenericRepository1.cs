using System.Collections.Generic;

using ValueReference.Contracts;
using ValueReference.ReferenceTypesExamples;

namespace ValueReference
{
    public class GenericRepository1 : IGenericRepository
    {
        public IList<IOpen> GetThingsToOpen()
        {
            var results = new List<IOpen>();
            var agendaService = new AgendaService();
            var letterService = new LetterService();
            var postCardService = new PostCardService();
            var anotherletterService = new LetterService();

            results.Add(anotherletterService);
            results.Add(letterService);
            results.Add(postCardService);
            results.Add(letterService);
            results.Add(agendaService);
            results.Add(anotherletterService);

            return results;
        }
    }
}
