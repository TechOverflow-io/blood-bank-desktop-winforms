using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Management_System_Layred.DTO
{
    class StockDTO
    {
        public StockDTO() { }

        private String _bloodGroup;
        private int _quantity;

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public String BloodGroup
        {
            get { return _bloodGroup; }
            set { _bloodGroup = value; }
        }
    }
}
