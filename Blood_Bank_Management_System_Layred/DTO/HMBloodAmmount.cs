using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Management_System_Layred.DTO
{
    class HMBloodAmmount
    {
        public HMBloodAmmount() { }

        private string _bloodGroup;
        private int _amount;
        private int _iD;

        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }


        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }


        public string BloodGroup
        {
            get { return _bloodGroup; }
            set { _bloodGroup = value; }
        }
    }
}
