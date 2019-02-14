using System;
using System.Collections.Generic;
using System.Text;

using ValueReference.Contracts;

namespace ValueReference.ReferenceTypesExamples
{
    public class LetterService: IOpen
    {
        private bool _isOpened = false;

        private bool _isEnvelopOpened = false;

        public void Open()
        {
            _isOpened = true;
            if (!_isEnvelopOpened)
            {
                _isEnvelopOpened = true;
                Console.WriteLine("Break the envelope first.");
            }

            Console.WriteLine("Get the letter out of envelope and read it");
        }

        public void Close()
        {
            _isOpened = false;
            Console.WriteLine("Put the letter in envelope");
        }

        public bool IsOpened()
        {
            return _isOpened;
        }
    }
}
