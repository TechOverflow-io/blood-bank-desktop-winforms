﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Management_System_Layred.DTO
{
    class LoginDTO
    {
        public LoginDTO()
        { }

        String _userName;
        String _password;

        public String UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }


        public String Password
        {
            get { return _password; }
            set { _password = value; }
        }

    }
}
