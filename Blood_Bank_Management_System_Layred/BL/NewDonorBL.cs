using Blood_Bank_Management_System_Layred.DL;
using Blood_Bank_Management_System_Layred.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Management_System_Layred.BL
{
    class NewDonorBL
    {
        NewDonorDL donorDL;

        public NewDonorBL()
        {
            donorDL = new NewDonorDL();
        }

        public int AddNewDonor(NewDonorDTO donorDTO)
        {
            int count = donorDL.InsertDonorInDB(donorDTO);
            return count;
        }

        public DataSet getMaxID()
        {
            return donorDL.getMaxIDFromDB();
        }

        public DataSet getAllDonorInfo(NewDonorDTO donorDTO)
        {
            return donorDL.getAllDonorInfoFromDB(donorDTO);
        }

        public int UpdateDonor(NewDonorDTO d)
        {
            int count = donorDL.UpdateDonor(d);
            return count;
        }
        public DataSet FetchAll()
        {
            return donorDL.FetchAllFromDB();
        }
        public DataSet fetchByAddress(NewDonorDTO d)
        {
            return donorDL.FetchByAddressFromDB(d);
        }
        public DataSet fetchByBloodGroup(NewDonorDTO d)
        {
            return donorDL.FetchByBloodGroupFromDB(d);
        }

        public int DeleteDonor(NewDonorDTO d)
        {
            int row = donorDL.DeleteDonorFromDB(d);
            return row;
        }
    }
}
