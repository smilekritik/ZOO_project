using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ZOO_main
{
    [Serializable]
    class Aviary
    {
        delegate void PrintMessage(string message);
        [field: NonSerialized]
        event PrintMessage Notify;

        delegate void JustFeed(int f);

        Stack<int> numbers = new Stack<int>();

        Amphibians _wolfs;
        Birds _bird;
        public Aviary() 
        {
        }
        public Aviary(string type, decimal count)
        {
            numbers.Push(1);
            var a = numbers.Peek();
            int get_element = numbers.Pop();

            if (type == "Земноводних тварин")
            {
                if (Notify != null) Notify("Зареестровано на земноводних тварин");
                _wolfs = new Amphibians(count);
            }
            else
            {
                Notify?.Invoke("Зареестровано на птахів");
                _bird = new Birds(count);
               // IRechoosed rec;
               // rec = _bird;
                //rec.Choose();
            }
        }
        public Aviary (Aviary aviary)
        {
            this._wolfs = aviary._wolfs;
            this._bird = aviary._bird;
        }
        public void FeedAviary(Aviary aviary)
        {
            JustFeed operation;
            if (GetType() == "Земноводних тварин")
            {
                operation = _wolfs.Feed;
            }
            else
            {
                operation = _bird.Feed;
            }
            operation(1);
        }
        public static Aviary operator ++(Aviary aviary)
        {
            Aviary new_aviary = new Aviary();
            new_aviary.SetWolfs(aviary.GetWolfs());
            return new_aviary;
        }

        public void SetWolfs(int count)
        {
            _wolfs.SetWolfs(count);
        }
        public int GetPrice()
        {
            if (GetType() == "Земноводних тварин")
            {
                if (Notify != null) Notify("Зареестровано на земноводних тварин");
                _wolfs = new Amphibians();
            }
            else
            {
                if (Notify != null) Notify("Зареестровано на птахів");
                _bird = new Birds();
                IRechoosed rec;
                rec = _bird;
                rec.Choose();
            }
            if (_wolfs != null)
            {
                return _wolfs.GetWolfs();
            }
            else
            {
                return _bird.GetWolfs();
            }
        }
        public string GetType()
        {
            if (_wolfs != null)
            {
                return "Земноводних тварин";
            }
            else
            {
                return "Птахів";
            }
        }
        public int GetWolfs()
        {
            return _wolfs.GetWolfs();
        }
        public virtual string GetInfo()
        {
            if (_wolfs != null)
            {
                return _wolfs.GetInfo();
            }
            else
            {
                return _bird.GetInfo();
            }
        }
    }
}
