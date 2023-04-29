using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.DAO
{
    internal abstract class DPAbtract
    {
        public abstract DataTable ExcuteQuery(string sql);
        public abstract int ExcuteNONQuery(string sql);
        public abstract object ExcuteScalarQuery(string sql);
    }
}
