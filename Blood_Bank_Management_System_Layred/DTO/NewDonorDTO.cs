using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Management_System_Layred.DTO
{
    class NewDonorDTO
    {

        public NewDonorDTO() { }

        private String _dName;
        private String _fname;
        private String _mname;
        private String _doB;
        private Int64 _moile;
        private String _gender;
        private String _email;
        private String _bgroup;
        private String _city;
        private String _address;
        private int _diD;

        public int DiD
        {
            get { return _diD; }
            set { _diD = value; }
        }

        public String Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public String City
        {
            get { return _city; }
            set { _city = value; }
        }


        public String Bgroup
        {
            get { return _bgroup; }
            set { _bgroup = value; }
        }


        public String Email
        {
            get { return _email; }
            set { _email = value; }
        }


        public String Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }


        public Int64 Moile
        {
            get { return _moile; }
            set { _moile = value; }
        }


        public String DoB
        {
            get { return _doB; }
            set { _doB = value; }
        }


        public String Mname
        {
            get { return _mname; }
            set { _mname = value; }
        }


        public String Fname
        {
            get { return _fname; }
            set { _fname = value; }
        }


        public String DName
        {
            get { return _dName; }
            set { _dName = value; }
        }

    }
}
