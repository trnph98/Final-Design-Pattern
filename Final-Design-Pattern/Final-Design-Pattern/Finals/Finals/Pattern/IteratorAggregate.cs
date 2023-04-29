using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.Pattern
{
    abstract class IteratorAggregate : IEnumerable
    {
        // Trả về một Iterator hoặc một IteratorAggregate khác 
        // cho đối tượng triển khai.
        public abstract IEnumerator GetEnumerator();
    }
}
