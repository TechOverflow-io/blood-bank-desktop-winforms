using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Management_System_Layred.DTO
{
    class HMangerDTO
    {
        public HMangerDTO() { }

        private String _bgroup;
        private String _address;
        private String _city;

        public String Bgroup
        {
            get { return _bgroup; }
            set { _bgroup = value; }
        }


        public String City
        {
            get { return _city; }
            set { _city = value; }
        }


        public String Address
        {
            get { return _address; }
            set { _address = value; }
        }
    }
}
