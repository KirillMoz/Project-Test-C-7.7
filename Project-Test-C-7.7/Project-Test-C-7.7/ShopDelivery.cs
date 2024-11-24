using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Test_C_7._7
{
    internal class ShopDelivery : Delivery
    {
        public override string Address
        {
            get { return this.Address; }
            set { this.Address = value; }
        }
        public override DateTime RegistrationDate
        {
            get { return this.RegistrationDate; }
            set { this.RegistrationDate = value; }
        }
        public override DateTime ReceiptDate
        {
            get { return this.ReceiptDate; }
            set { this.ReceiptDate = value; }
        }

        public string ShopName { get; set; }
        public int ShelfLife { get; set; }
        protected DateTime DateDelivery { get; set; }

        public ShopDelivery(string ShopName, int ShelfLife, string Address)
        {
            this.ShopName = ShopName;
            this.ShelfLife = ShelfLife;
            this.Address = Address;
            this.RegistrationDate = DateTime.Now;
            this.ReceiptDate = DateTime.Now;
        }
    }
}
