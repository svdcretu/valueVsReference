using System;
using System.Collections.Generic;

using ValueReference.Contracts;

namespace ValueReference
{
    public class GenericProcessor : IGenericProcessor
    {
        private IGenericRepository _repository;

        private readonly IList<IOpen> _listToProcess;

        public GenericProcessor(IGenericRepository repository)
        {
            _repository = repository;
            _listToProcess = _repository.GetThingsToOpen();
        }

        public void OpenThings()
        {
            foreach (IOpen itemToProcess in _listToProcess)
            {
                if (!itemToProcess.IsOpened())
                {
                    itemToProcess.Open();
                    Console.WriteLine();
                }
            }
        }

        public void CloseThings()
        {
            foreach (IOpen itemToProcess in _listToProcess)
            {
                if (itemToProcess.IsOpened())
                {
                    itemToProcess.Close();
                }
            }
        }
    }
}
