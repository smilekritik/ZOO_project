using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ZOO_main
{
    class Birds : Aviary, IRechoosed
    {
        protected decimal _count;
        protected int _price;

        private Dictionary<int, string> _animals = new Dictionary<int, string>(5);
        private Queue<int> _feed = new Queue<int>();
       
        void IRechoosed.Choose() //явно
        {
            _count = 1;
        }
        public Birds()
        {
            this._count = 1;
            this._price = 30;

            this._animals.Add(1, "Owl");
            this._animals[2] = "Parrot";

            var a = this._animals[2];
        }
        public Birds(decimal count)
        {
            this._count = count;
            this._price = 50;
        }
        ~Birds()
        {
            foreach (KeyValuePair<int, string> keyValue in _animals)
            {
                _animals.Remove(keyValue.Key);
            }
            
        }
        public int GetCount()
        {
            return _count;
        }
        public int GetPrice()
        {
            return _price;
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
            return $"Відвідувань воль'ерів з птицями - {_count} ";
        }
    }
}
