﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO_main
{
    class Wolfs : Aviary
    {
        protected int _count;

        public Wolfs(int count)
        {
            this._count = count;
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
