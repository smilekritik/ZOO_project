using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO_main
{
    class Aviary
    {
        Amphibians _wolfs;
        Birds _bird;
        public Aviary() 
        {
        }
        public Aviary(string type)
        {
            if (type == "Земноводні")
            {
                _wolfs = new Amphibians();
            }
            else
            {
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
