using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO_main
{
    class Birds : Aviary, IRechoosed
    {
        protected int _count;
        void IRechoosed.Choose() //явно
        {
            _count = 1;
        }
        public Birds()
        {
            this._count = 1;
        }

        public int GetCount()
        {
            return _count;
        }
        public void SetCount(int count)
        {
            this._count = count;
        }

        public override string GetInfo()
        {
            return $"Count with wolfs: {_count}";
        }
    }
}
