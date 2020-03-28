using System;
using System.Collections.Generic;
using System.Text;

namespace Microcapital.PostcodeAnywhere
{
    public class Class1
    {
        private int _count = 1;
        public Class1()
        {
            _count = 3;
        }

        public int Count()
        {
            _count++;
            if (_count % 2 == 0)
                return _count;
            else return 0;
        }
    }
}
