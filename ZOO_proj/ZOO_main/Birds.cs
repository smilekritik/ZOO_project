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
        protected int _price;
        void IRechoosed.Choose() //явно
        {
            _count = 1;
        }
        public Birds()
        {
            this._count = 1;
            this._price = 30;
        }

        public int GetCount()
        {
            return _count;
        }
        public int GetPrice()
        {
            return _price;
        }

        public void Feed()
        {
            int nothing = 0;
        }

        public void SetPrice(int price)
        {
            this._price = price;
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
