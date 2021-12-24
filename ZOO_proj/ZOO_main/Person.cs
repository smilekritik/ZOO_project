using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO_main
{
    [Serializable]
    class Person : Ticket, IComparable
    {
        protected string _name;
        protected string _soname;
        public int CompareTo(object obj)
        {
            var tick = (Person)obj;
            return this.GetName().CompareTo(tick.GetName());
        }
        public Person(string name, string soname)
        {
            /*try
            {
                this._name = name;
                this._soname = soname;
            }
            catch (PersonException exexpt)
            {
                Console.WriteLine("Помилка: " + exexpt.Message);
            }*/



            if(name == "" || soname == "")
            {
                if (name == "") {
                    throw new PersonException("Ім'я не повинно містити пусті поля", name);
                }
                else
                {
                    throw new PersonException("Прізвище не повинно містити пусті поля", soname);
                }
            }
            else
            {
                this._name = name;
                this._soname = soname;
            }
        }
        public override string GetInfo()
        {
            return " " + base.GetInfo() + $"Ім'я: {_name}, Прізвище: {_soname}";
        }
        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            this._name = name;
        }
        public string GetSoname()
        {
            return _soname;
        }
        public void SetSoname(string soname)
        {
            this._soname = soname;
        }
     }
}
