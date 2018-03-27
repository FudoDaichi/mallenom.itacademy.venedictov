using System;
using System.Collections.Generic;

namespace practice.linq
{
    /// <summary>/// </summary>
    public interface IEnumerableConverter
    {
        /// <summary>/// </summary>
        IEnumerable<int> Convert(List<int> list);
    }
}
