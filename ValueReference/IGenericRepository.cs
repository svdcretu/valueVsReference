using System.Collections.Generic;
using ValueReference.Contracts;

namespace ValueReference
{
    public interface IGenericRepository
    {
        IList<IOpen> GetThingsToOpen();
    }
}