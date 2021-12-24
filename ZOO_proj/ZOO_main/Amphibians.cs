using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO_main
{
    [Serializable]
    class Amphibians : Aviary, IRechoosed
    {
        protected decimal _count;
        protected int _price;

        private Queue<int> _feed = new Queue<int>();

        public void Choose() //неявно
        {
            _count = 1;
        }
        public Amphibians()
        {
            this._count = 1;
            this._price = 50;
        }
        public Amphibians(decimal count)
        {
            this._count = count;
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

        public void Feed(int to_feed)
        {
            _feed.Enqueue(to_feed);
        }
        public int Get_Feed()
        {
            var a = _feed.Peek();
            return _feed.Dequeue();
        }
        public decimal GetCount()
        {
            return _count;
        }
        public void SetCount(decimal count)
        {
            this._count = count;
        }

        public override string GetInfo()
        {
            return $"Відвідувань воль'ерів з земноводними тваринами - {_count} ";
        }
    }
}
