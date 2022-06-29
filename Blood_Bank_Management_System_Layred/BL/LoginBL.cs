using Blood_Bank_Management_System_Layred.DL;
using Blood_Bank_Management_System_Layred.DTO;
using Blood_Bank_Management_System_Layred.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank_Management_System_Layred.BL
{

    class LoginBL
    {
        LoginDL lgDL;
        public LoginBL()
        {
            lgDL = new LoginDL();
        }

        public Form VerifyUser(LoginDTO lg)
        {
            // Here we call loginDL objects method verifyUserFromDB
            string res = lgDL.VerifyUsersFromDB(lg);
            if (res == "admin")
            {
                return new AdminMainGUI();
            }
            else if (res == "donor")
            {
                return new DonorMainGUI();
            }
            else if (res == "mager")
            {
                return new HManager();
            }
            else
            {
                //return new WrongUserGUI();
            }
            //return new WrongUserGUI();

            // Change ReturnType Also
            return new WrongUserGUI();

        }

    }
}
