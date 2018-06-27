using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfficientCareLookUp.Data
{
    public class Component
    {
        private string productNumber;
        private string bin;
        private string warehouse;
        private int qty;

        public string ProductNumber { get { return productNumber; } }
        public string Bin { get { return bin; } }
        public string Warehouse { get { return warehouse; } }
        public int Quantity { get { return qty; } }

        public Component(string productNumber, int qty, string bin, string warehouse)
        {
            this.productNumber = productNumber;
            this.bin = bin;
            this.warehouse = warehouse;
            this.qty = qty;
        }
    }
}
