using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO_main
{
    class Amphibians : Aviary, IRechoosed
    {
        protected int _count;
        protected int _price;
        public void Choose() //неявно
        {
            _count = 1;
        }
        public Amphibians()
        {
            this._count = 1;
            this._price = 50;
        }
        public int GetPrice()
        {
            return _price;
        }
        public void SetPrice(int price)
        {
            this._price = price;
        }

        public void Feed()
        {
            int nothing = 0;
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
