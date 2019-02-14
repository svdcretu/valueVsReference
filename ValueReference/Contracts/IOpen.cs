using System;
using System.Collections.Generic;
using System.Text;

namespace ValueReference.Contracts
{
    public interface IOpen
    {
        void Open();

        void Close();

        bool IsOpened();
    }
}
