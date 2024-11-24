using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Test_C_7._7
{
    internal class HomeDelivery : Delivery
    {
        private string address;
        private DateTime registrationDate;
        private DateTime receiptDate;
        public override string Address
        {
            get { return address; }
            set { address = value; }
        }
        public override DateTime RegistrationDate 
        {
            get { return registrationDate; }
            set { registrationDate = value; }
        }
        public override DateTime ReceiptDate 
        {
            get { return receiptDate; }
            set { receiptDate = value; }
        }

        public string Comment 
        { 
            get { return this.Comment; }
            set { this.Comment = value; } 
        }

        public HomeDelivery(string Address, DateTime RegistrationDate, DateTime ReceiptDate) {
            address = Address;
            registrationDate = RegistrationDate;
            receiptDate = ReceiptDate;
        }
    }
}
