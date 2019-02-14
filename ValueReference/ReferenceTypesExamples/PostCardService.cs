using System;
using System.Collections.Generic;
using System.Text;

using ValueReference.Contracts;

namespace ValueReference.ReferenceTypesExamples
{
    public class PostCardService: IOpen
    {
        private bool _isOpened = false;

        public void Open()
        {
            _isOpened = true;
            
            Console.WriteLine("Turn the post card to it's back and red it");
        }

        public void Close()
        {
            _isOpened = false;
            Console.WriteLine("Turn the post card on it's front");
        }

        public bool IsOpened()
        {
            return _isOpened;
        }
    }
}
