using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.DTO
{
    internal class ReceiptDTO
    {
        private string _receiptId;
        private int _totalprice;
        public ReceiptDTO() { }

        public ReceiptDTO(string receiptId, int totalprice)
        {
            _receiptId = receiptId;
            _totalprice = totalprice;
        }

        public string ReceiptId { get => _receiptId; set => _receiptId = value; }
        public int Totalprice { get => _totalprice; set => _totalprice = value; }

        public ReceiptDTO(DataRow row)
        {
            this.ReceiptId = row["ReceiptID"].ToString();
            this.Totalprice = (int)row["TotalPrice"];
        }
    }
}
