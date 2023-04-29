using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.DTO
{
    internal class GoodDTO
    {
        private string _goodid;
        private string _name;
        private string _unit;
        private int _price;
        private string _describe;
        private string _image;
        private int _amount;
        private string _supplier;
        public GoodDTO()
        {
        }

        public string Goodid { get => _goodid; set => _goodid = value; }
        public string Name { get => _name; set => _name = value; }
        public string Unit { get => _unit; set => _unit = value; }
        public int Price { get => _price; set => _price = value; }
        public string Describe { get => _describe; set => _describe = value; }
        public string Image { get => _image; set => _image = value; }
        public int Amount { get => _amount; set => _amount = value; }
        public string Supplier { get => _supplier; set => _supplier = value; }

        public GoodDTO(string goodid, string name, string unit, int price, string describe, string image, int amount, string supplier)
        {
            this.Goodid = goodid;
            this.Name = name;
            this.Unit = unit;
            this.Price = price;
            this.Describe = describe;
            this.Image = image;
            this.Amount = amount;
            this.Supplier = supplier;

        }
        public GoodDTO(DataRow row)
        {
            this.Goodid = row["GoodId"].ToString();
            this.Name = row["Name"].ToString();
            this.Unit = row["Unit"].ToString();
            this.Price = (int)row["Price"];
            this.Describe = row["Describe"].ToString();
            this.Image = row["Image"].ToString();
            this.Amount = (int)row["Amount"];
            this.Supplier = row["Supplier"].ToString();
        }
    }
}
