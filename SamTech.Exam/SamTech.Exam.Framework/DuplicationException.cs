using System;
using System.Collections.Generic;
using System.Text;

namespace SamTech.Exam.Framework
{
    public class DuplicationException : Exception
    {
        public string DublicateItemName { get; private set; }

        public DuplicationException(string message, string itemName)
            : base(message)
        {
            DublicateItemName = itemName;
        }
    }
}
