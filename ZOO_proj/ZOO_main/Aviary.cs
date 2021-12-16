using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ZOO_main
{
    class Aviary
    {
        delegate void PrintMessage(string message);
        event PrintMessage Notify;

        delegate void JustFeed(int f);

        Stack<int> numbers = new Stack<int>();

        Amphibians _wolfs;
        Birds _bird;
        public Aviary() 
        {
        }
        public Aviary(string type)
        {
            numbers.Push(1);
            int get_element = numbers.Pop();

            if (type == "Земноводні")
            {
                if (Notify != null) Notify("Зареестровано на земноводних тварин");
                _wolfs = new Amphibians();
            }
            else
            {
                Notify?.Invoke("Зареестровано на птахів");
                _bird = new Birds();
                IRechoosed rec;
                rec = _bird;
                rec.Choose();
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
            if (GetType() == "Земноводні")
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
            if (GetType() == "Земноводні")
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
                return "Земноводні";
            }
            else
            {
                return "Птахи";
            }
        }
        public int GetWolfs()
        {
            return _wolfs.GetWolfs();
        }
        public virtual string GetInfo()
        {

            return $"Wolfs visiters: {_wolfs.GetCount()}";

        }
    }
}
