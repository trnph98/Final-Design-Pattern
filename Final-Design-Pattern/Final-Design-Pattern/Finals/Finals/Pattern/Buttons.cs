using Finals.DAO;
using Finals.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals.Pattern
{
    internal class Buttons
    {
        public void TurnOn()
        {
            List<GoodDTO> goodlist = new List<GoodDTO>(GoodDAO.Instance.GetGoodDTO());
            string[,] goodarray = new string[goodlist.Count(), 8];

            for (int i = 0; i < goodlist.Count(); i++)
            {

                goodarray[i, 0] = goodlist[i].Goodid.ToString();
                goodarray[i, 1] = goodlist[i].Name.ToString();
                goodarray[i, 2] = goodlist[i].Unit.ToString();
                goodarray[i, 3] = goodlist[i].Price.ToString();
                goodarray[i, 4] = goodlist[i].Describe.ToString();
                goodarray[i, 5] = goodlist[i].Image.ToString();
                goodarray[i, 6] = goodlist[i].Amount.ToString();
                goodarray[i, 7] = goodlist[i].Supplier.ToString();
            }
            ITarget target = new GoodAdapter();
            target.Proceeds(goodarray);
            MessageBox.Show(target.Proceeds(goodarray));
        }
        public void TurnOff()
        {
            Console.WriteLine("Turn off");
        }
    }
}
