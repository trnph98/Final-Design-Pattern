using Finals.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.DAO;

namespace Finals.Pattern
{
    internal class Adapter
    {
        public String Proceed(List<GoodDTO> goods)
        {
            String str = "";
            foreach(GoodDTO good in goods)
            {
                str +=  good.Name.ToString()+" đã bán: "+ CartDAO.Instance.proceeds(good.Goodid).ToString() +" sản phẩm. \r";
            }
            return str;
            
        }
    }
}
