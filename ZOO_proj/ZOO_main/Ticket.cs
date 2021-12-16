using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO_main
{
    class Ticket : IComparable
    {
        protected Person _person;
        protected List<Aviary> _aviaries;

        delegate double Operation(double x, double y);
        protected HashSet<int> _id = new HashSet<int>();

        SortedList<int, string> workers = new SortedList<int, string>();

        //public int CompareTo(Ticket tick)
        //{
        //    return this.GetPerson().GetName().CompareTo(tick.GetPerson().GetName());
        //}
        public int CompareTo(object obj)
        {
            var tick = (Ticket)obj;
            return this.GetPerson().GetName().CompareTo(tick.GetPerson().GetName());
        }
        public Ticket()
        {
            Random rnd = new Random();
            bool check = false;
            do
            {
                int id = rnd.Next();
                if (!_id.Contains(id))
                {
                    check = true;
                    _id.Add(id);
                }
            } while (check == false);
        }

        public Ticket(string name, string soname, int wolfs)
        {
            _person = new Person(name, soname);
            _aviaries = new List<Aviary>();

            Aviary test = new Aviary();
            _aviaries.AddRange(new Aviary[] { test });
            workers.Add(4, "Alina");
            workers.Add(2, "Alina");
            //foreach (int key in workers.Keys)
            //{
            //    Console.WriteLine(key + " = " + workers[key]);
            //}
        }
        public Ticket(string name, string soname, Aviary aviary)
        {
            _person = new Person(name, soname);
            //_aviary = new Aviary(aviary);
        }

        public Ticket(string name, string soname)
        {
            _person = new Person(name, soname);
        }

        public void AddAviary(Aviary toadd)
        {
            _aviaries = new List<Aviary>();
            _aviaries.AddRange(new Aviary[] { toadd });
        }
        public int GetId()
        {
            return _id;
        }
        public double GetKoef(Aviary avs, List<Aviary> aviaries)
        {
            double count = 0;

            Operation adds = delegate (double x, double y)
            {
            return x + y;
            };

            Operation adds2 = (x, y) => x + y;


            foreach (Aviary av in aviaries)
            {
                if (avs.GetType() == av.GetType())
                {
                    count = adds(count, av.GetPrice());
                }
            }
            if (count <= 1)
            {
                return 1.2;
            }
            else if (count <= 3)
            {
                return 1;
            }
            else
            {
                return 0.8;
            }
        }
        public double GetPrice()
        {
            double price = 0;
            Operation del = Add;
            Operation some = Multiply;
            foreach (Aviary av in _aviaries)
            {
                price = del(price, av.GetPrice());
                price = some(price, GetKoef(av, _aviaries));
            }
            return price;
        }
        public Person GetPerson()
        {
            return _person;
        }
        /*public Aviary GetAviary() {
            return _aviary;
        }*/
        public virtual string GetInfo()
        {
            return $"id: {_id} ";
        }
        private static double Add(double x, double y)
        {
            return x + y;
        }
        private static double Multiply(double x, double y)
        {
            return x * y;
        }
        private static double Division(double x, double y)
        {
            return x * y;
        }
    }
}
