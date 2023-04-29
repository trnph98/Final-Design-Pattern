using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.DTO
{
    internal class CartDTO
    {
        private string _cartId;
        private string _name;
        private string _agency;
        private string _status;
        private string _payment;
        private int _totalprice;

        protected static CartDTO uniqueInstance;
        public CartDTO(string cartId, string name, string agency, string status, string payment, int totalprice)
        {
            _cartId = cartId;
            _name = name;
            _agency = agency;
            _status = status;
            _payment = payment;
            _totalprice = totalprice;
        }
        public string CartId { get => _cartId; set => _cartId = value; }
        public string Name { get => _name; set => _name = value; }
        public string Agency { get => _agency; set => _agency = value; }
        public string Status { get => _status; set => _status = value; }
        public string Payment { get => _payment; set => _payment = value; }
        public int TotalPrice { get => _totalprice; set => _totalprice = value; }
        public CartDTO(DataRow row)
        {
            this.CartId = row["CartID"].ToString();
            this.Name = row["Name"].ToString();
            this.Agency = row["Agency"].ToString();
            this.Status = row["Status"].ToString();
            this.Payment = row["Payment_Method"].ToString();
            this.TotalPrice = (int)row["TotalPrice"];
        }

    }
}
