using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.linq
{
    class MyConv : IEnumerableConverter
    {
        public IEnumerable<int> Convert(List<int> list)
        {
            return list.Skip(5).Take(20).Where(i => i > 10 && i < 100).OrderBy(i=>i);
        }
    }
}
