using System;
using System.Collections.Generic;
using System.Linq;


namespace practice.linq
{
    /// <summary>/// </summary>
    public class LinqConv : IEnumerableConverter
    {
        /// <summary>/// </summary>
        public IEnumerable<int> Convert(List<int> list)
        {
            return from el in list.Skip(5).Take(20)
                   where el > 10 && el < 100
                   orderby el
                   select el;
        }
    }


}
