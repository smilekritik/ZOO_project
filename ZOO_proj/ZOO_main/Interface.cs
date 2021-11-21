using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO_main
{
    public interface IComparable
    {
        int CompareTo(object o);
    }
    public interface IRechoosed
    {
        void Choose();
    }
}
