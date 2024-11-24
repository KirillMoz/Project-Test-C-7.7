using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Test_C_7._7
{
    abstract class Delivery
    {
        public abstract string Address { get; set; }
        public abstract DateTime RegistrationDate { get; set; }
        public abstract DateTime ReceiptDate { get; set; }

        public virtual void Print() { }

    }


}
