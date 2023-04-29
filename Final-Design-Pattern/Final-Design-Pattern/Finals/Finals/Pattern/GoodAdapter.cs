using DevExpress.Office;
using Finals.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.Pattern
{
    public class GoodAdapter : ITarget
    {
        Adapter adapter = new Adapter();
        public String Proceeds(string[,] cartArray)
        {
            string _goodid = null;
            string _name = null;
            string _unit = null;
            int _price = 0;
            string _describe = null;
            string _image = null;
            int _amount = 0;
            string _supplier = null;
            List<GoodDTO> listgoods = new List<GoodDTO>();
            for (int i = 0; i < cartArray.GetLength(0); i++)
            {
                for (int j = 0; j < cartArray.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        _goodid = cartArray[i, j];
                    }
                    else if (j == 1)
                    {
                        _name = cartArray[i, j];
                    }
                    else if (j == 2)
                    {
                        _unit = cartArray[i, j];
                    }
                    else if (j == 3)
                    {
                        _price = int.Parse(cartArray[i, j]);
                    }
                    else if (j == 4)
                    {
                        _describe = cartArray[i, j];
                    }
                    else if (j == 5)
                    {
                        _image = cartArray[i, j];
                    }
                    else if (j == 6)
                    {
                        _amount = int.Parse(cartArray[i, j]);
                    }
                    else if (j == 7)
                    {
                        _supplier = cartArray[i, j];
                    }
                }
                listgoods.Add(new GoodDTO(_goodid,_name,_unit,_price,_describe,_image,_amount,_supplier));
            }
            return adapter.Proceed(listgoods);
        }
    }
}
