using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.DAO;

namespace Finals.Pattern
{
    internal interface ITarget
    {
        String Proceeds(string[,] cartArray);
    }
}
