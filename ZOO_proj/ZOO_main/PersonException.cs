using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO_main
{
    class PersonException : Exception
    {
        public string Name { get; set; }
        public PersonException(string message, string text)
                : base(message)
        {
            Name = text;
        }
    }
}
