using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO_main
{
    class Ticket
    {
        protected int _id;
        protected Person _person;
        protected Aviary _aviary;

        public Ticket()
        {
        }

        public Ticket(string name, string soname, int wolfs)
        {
            _id = 0;
            _person = new Person(name, soname);
            //_person.SetName(name);
           // _person.SetSoname(soname);
            _aviary = new Aviary();
        }
        public Ticket(string name, string soname, Aviary aviary)
        {
            _id = 0;
            _person = new Person(name, soname);
            _aviary = new Aviary(aviary);
        }

        public Ticket(string name, string soname)
        {
            _id = 0;
            _person.SetName(name);
            _person.SetSoname(soname);
        }

        public int GetId()
        {
            return _id;
        }
        public Person GetPerson() {
            return _person;
        }
        public Aviary GetAviary() {
            return _aviary;
        }
        public virtual string GetInfo()
        {
            return $"id: {_id} {_person.GetInfo()}";
        }
    }
}
