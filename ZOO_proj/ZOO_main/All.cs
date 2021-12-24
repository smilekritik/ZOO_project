using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO_main
{
    [Serializable]
    class All<T>
    {
        protected T _example;

        public All(T some)
        {
            _example = some;
        }
        public T Example
        {
            get { return _example; }
            set { _example = value; }
        }

        public void Print(string message)
        {
            Console.Write(message + " => ");
            Console.WriteLine("_example = {0}", _example);
        }
    }
}
