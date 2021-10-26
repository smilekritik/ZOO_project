using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO_main
{
    class Person : Ticket
    {
        protected string _name;
        protected string _soname;

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
                throw new PersonException("Ім'я ті прізвище не повинно містити пусті поля");
            }
            else
            {
                this._name = name;
                this._soname = soname;
            }
        }
        public override string GetInfo()
        {
            return " " + base.GetInfo() + $"name: {_name}, soname: {_soname}";
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
